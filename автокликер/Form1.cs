using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace автокликер
{
    public partial class MainForm : Form
    {
        #region здесь хранятся все коды нажатия клавиш мыши
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }
        #endregion

        GlobalKeyboardHook gkh;

        int element;
        int[] massCoordX;
        int[] massCoordY;

        //переменные времени
        int s, m, h;

        Timer timerClicker, timer; //таймер, просто для примера

        int timeStop;
        int countStop;
        int clickCount; //записываем сюда кол-во кликов
        bool activeForm; //на считывание кликов

        public MainForm()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Tick += new EventHandler(tickTime);

            //таймер на клик
            timerClicker = new Timer();
            timerClicker.Tick += new EventHandler(timerClicker_Tick);

            this.Activated += new EventHandler(MAINFORM_FOCUSED);
            this.Deactivate += new EventHandler(MAINFORM_UNFOCUSED);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_TimeStop.Text = "0".ToString();
            tb_ClickStop.Text = "0".ToString();
            tb_ClickInterval.Text = "900".ToString();
            lbl_Null.Focus();

            gkh = new GlobalKeyboardHook();
            gkh.HookedKeys.Add(Keys.Space);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUpSpace);

            gkh.HookedKeys.Add(Keys.Escape);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUpEscape);

            gkh.HookedKeys.Add(Keys.Delete);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUpDelete);

            element = 0;
            massCoordX = new int[0];
            massCoordY = new int[0];

            //переменные времени
            s = 0; m = 0; h = 0;

            timeStop = 0;
            countStop = 0;
            clickCount = 0; //записываем сюда кол-во кликов
            activeForm = true; //на считывание кликов
        }

        private void tickTime(object sender, EventArgs e)
        {
            s = s + 1;
            if (s == 60)
            {
                m = m + 1;
                s = 0;
            }

            if (m == 60)
            {
                h = h + 1;
                m = 0;
            }

            lbl_TimeCount.Text = (String.Format("{0: 00}", h)
                     + ":" + String.Format("{0: 00}", m)
                     + ":" + String.Format("{0: 00}", s)).ToString();
        }

        private void timerClicker_Tick(object sender, EventArgs e)
        {
            if (countStop != 0)
            {
                if (countStop == (clickCount + 1))
                {
                    timerClicker.Stop();
                    timer.Stop();
                    Console.WriteLine("стоп countStop");

                    tb_ClickInterval.Enabled = true;
                    tb_ClickStop.Enabled = true;
                    tb_TimeStop.Enabled = true;
                }
            }

            if (timeStop != 0)
            {
                if (timeStop == m)
                {
                    timerClicker.Stop();
                    timer.Stop();
                    Console.WriteLine("стоп timeStop");

                    tb_ClickInterval.Enabled = true;
                    tb_ClickStop.Enabled = true;
                    tb_TimeStop.Enabled = true;
                }
            }

            /*
            richTextBox1.Select(0, richTextBox1.Lines[clickCount % element].Length);
            Console.WriteLine("ff" + richTextBox1.Lines[clickCount % element]);
            richTextBox1.SelectionBackColor = Color.Gray;

            //richTextBox1.SelectionColor = Color.Red;
            richTextBox1.Select(str[0].Length, str[1].Length + 1);
            */

            DoMouseClick(massCoordX[clickCount % element], massCoordY[clickCount % element]);
        }

        //метод имитации клика на экране
        private void DoMouseClick(int X, int Y)
        {
            int ClickX = X * (65535 / SystemInformation.PrimaryMonitorSize.Width);
            int ClickY = Y * (65535 / SystemInformation.PrimaryMonitorSize.Height);

            if (rButtonLMC.Checked == true)
            {
                //Перемещение курсора на указанные координаты
                mouse_event((int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.MOVE,
                    ClickX, ClickY, 0, 0);

                //Выполнение первого клика левой клавишей мыши
                mouse_event((int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.LEFTDOWN | (int)MouseEventFlags.LEFTUP, X, Y, 0, 0);

                //увеличиваем счетчик нажатий
                clickCount++;

                //выводим кол-во кликов
                tb_ClickCount.Text = clickCount.ToString();

                //модуль для отладки
                /*
                Console.WriteLine("ЛКМ клик");

                Console.WriteLine("Width " + SystemInformation.PrimaryMonitorSize.Width);
                Console.WriteLine("Height " + SystemInformation.PrimaryMonitorSize.Height);
                Console.WriteLine("X: " + X + "Y: " + Y);

                Console.WriteLine("ClickX " + ClickX);
                Console.WriteLine("ClickY " + ClickY);
                */
                //модуль для отладки

            }
            if (rButtonRMC.Checked == true)
            {
                //Перемещение курсора на указанные координаты
                mouse_event((int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.MOVE,
                    ClickX, ClickY, 0, 0);

                //Выполнение первого клика левой клавишей мыши
                mouse_event((int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.RIGHTDOWN | (int)MouseEventFlags.RIGHTUP, X, Y, 0, 0);

                //увеличиваем счетчик нажатий
                clickCount++;

                //выводим кол-во кликов
                tb_ClickCount.Text = clickCount.ToString();
                /*
                //модуль для отладки
                Console.WriteLine("ПКМ клик");
                Console.WriteLine("X: " + X + "Y: " + Y);

                Console.WriteLine("ClickX " + ClickX);
                Console.WriteLine("ClickY " + ClickY);
                //модуль для отладки
                */
            }

        }

        //событие обработки нажатия Delete
        private void gkh_KeyUpDelete(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                rtb_CoordList.Text = "";
                Array.Resize(ref massCoordX, 0);
                Array.Resize(ref massCoordY, 0);
                element = 0;
                lbl_CountPointClick.Text = element.ToString();
            }
        }

        //событие обработки нажатия ESc
        private void gkh_KeyUpEscape(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                timerClicker.Stop();
                timer.Stop();

                Console.WriteLine("Stop");

                tb_ClickInterval.Enabled = true;
                tb_ClickStop.Enabled = true;
                tb_TimeStop.Enabled = true;
            }

        }

        //событие обработки нажатия пробела
        private void gkh_KeyUpSpace(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && activeForm == true)
            {
                Array.Resize(ref massCoordX, (massCoordX.Length + 1));
                Array.Resize(ref massCoordY, (massCoordY.Length + 1));

                int X = (int)Cursor.Position.X;
                int Y = (int)Cursor.Position.Y;

                tb_coordX.Text = X.ToString();
                tb_coordY.Text = Y.ToString();

                rtb_CoordList.Text += "X: " + X + " " + "Y: " + Y + "\r";

                for (int i = element; i < massCoordX.Length; i++)
                {
                    massCoordX[i] = X;
                    massCoordY[i] = Y;
                }
                element++;

                lbl_CountPointClick.Text = element.ToString();
                lbl_Null.Focus();
            }
        }

        private void MAINFORM_FOCUSED(object sender, EventArgs e)
        {
            //когда активированно 
            activeForm = true;
        }

        private void MAINFORM_UNFOCUSED(object sender, EventArgs e)
        {
            //когда деактивированно 
            activeForm = false;
        }

        private void checkBoxWindowsTop_Click(object sender, EventArgs e)
        {
            if (cb_WindowsTop.Checked == true)
            {
                TopMost = true;
                //Console.WriteLine("true");
                lbl_Null.Focus();
            }

            if (cb_WindowsTop.Checked == false)
            {
                TopMost = false;
                //Console.WriteLine("false");
                lbl_Null.Focus();
            }
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void buttonSaveListCoord_Click(object sender, EventArgs e)
        {
            string path;
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text Documents|*.txt",
                ValidateNames = true
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        path = sfd.FileName;
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            //интервал кликов
                            await sw.WriteLineAsync(tb_ClickInterval.Text);

                            //клим мышки л/п
                            await sw.WriteLineAsync(rButtonLMC.Checked.ToString());
                            await sw.WriteLineAsync(rButtonRMC.Checked.ToString());

                            //размер массива
                            await sw.WriteLineAsync(massCoordX.Length.ToString());

                            //await sw.WriteLineAsync("Xstart");
                            for (int i = 0; i < massCoordX.Length; i++)
                            {
                                await sw.WriteLineAsync(massCoordX[i].ToString());
                            }

                            //await sw.WriteLineAsync("Ystart");
                            for (int i = 0; i < massCoordY.Length; i++)
                            {
                                await sw.WriteLineAsync(massCoordY[i].ToString());
                            }
                            //wait sw.WriteLineAsync("конец");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonLoadCoord_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Text Documents |*.txt",
                ValidateNames = true,
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            tb_ClickInterval.Text = sr.ReadLine();
                            rButtonLMC.Checked = Convert.ToBoolean(sr.ReadLine());
                            rButtonRMC.Checked = Convert.ToBoolean(sr.ReadLine());
                            int size = Convert.ToInt32(sr.ReadLine());

                            Array.Resize(ref massCoordX, size);
                            Array.Resize(ref massCoordY, size);

                            element = size;

                            for (int i = 0; i < massCoordX.Length; i++)
                            {
                                massCoordX[i] = Convert.ToInt32(sr.ReadLine());
                            }
                            for (int i = 0; i < massCoordY.Length; i++)
                            {
                                massCoordY[i] = Convert.ToInt32(sr.ReadLine());
                            }
                            Console.WriteLine(sr.ReadLine());

                            for (int i = 0; i < massCoordX.Length; i++)
                            {
                                rtb_CoordList.Text += "X: " + massCoordX[i] + " " + "Y: " + massCoordY[i] + "\r";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonStartClick_Click(object sender, EventArgs e)
        {
            s = 0; m = 0; h = 0;
            clickCount = 0;

            countStop = Convert.ToInt32(tb_ClickStop.Text);
            timeStop = Convert.ToInt32(tb_TimeStop.Text);

            timerClicker.Interval = Convert.ToInt32(tb_ClickInterval.Text);
            timerClicker.Start();

            timer.Interval = 1000;
            timer.Start();

            tb_ClickInterval.Enabled = false;
            tb_ClickStop.Enabled = false;
            tb_TimeStop.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lbl_Null.Focus();
        }
    }
}
