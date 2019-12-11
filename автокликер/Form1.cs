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
    public partial class Form1 : Form
    {

        //===========================================
        //здесь хранятся все коды нажатия клавиш мыши
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
        //===========================================
        string path; //для сохранения в фаил

        globalKeyboardHook gkh = new globalKeyboardHook();

        int element = 0;
        int[] massCoordX = new int[0];
        int[] massCoordY = new int[0];

        //переменные времени
        int s = 0, m = 0, h = 0;

        Timer timerClicker, timer; //таймер, просто для примера

        int timeStop = 0;
        int countStop = 0;
        int clickCount = 0; //записываем сюда кол-во кликов
        bool activeForm = true; //на считывание кликов

        public Form1()
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

        void tickTime(object sender, EventArgs e)
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

            label12.Text = (String.Format("{0: 00}", h)
                     + ":" + String.Format("{0: 00}", m)
                     + ":" + String.Format("{0: 00}", s)).ToString();
        }

        void timerClicker_Tick(object sender, EventArgs e)
        {
            
            //Console.WriteLine("clickCount " + clickCount);
            //Console.WriteLine("element " + element);
            Console.WriteLine("clickCount % element " + clickCount % element);
         

            if (countStop != 0)
            {
                if(countStop == (clickCount+1))
                {
                    timerClicker.Stop();
                    timer.Stop();
                    Console.WriteLine("стоп countStop");

                    textBox10.Enabled = true;
                    textBox6.Enabled = true;
                    textBox8.Enabled = true;
                }
            }

            if (timeStop != 0)
            {
                if (timeStop == m)
                {
                    timerClicker.Stop();
                    timer.Stop();
                    Console.WriteLine("стоп timeStop");

                    textBox10.Enabled = true;
                    textBox6.Enabled = true;
                    textBox8.Enabled = true;
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
        public void DoMouseClick(int X, int Y)
        {
            
          
            int ClickX = X * (65535 / SystemInformation.PrimaryMonitorSize.Width);
            int ClickY = Y * (65535 / SystemInformation.PrimaryMonitorSize.Height);

            if(radioButton1.Checked == true)
            {
                //Перемещение курсора на указанные координаты
                mouse_event( (int)MouseEventFlags.ABSOLUTE| (int)MouseEventFlags.MOVE,
                    ClickX, ClickY, 0, 0);
                
                //Выполнение первого клика левой клавишей мыши
                mouse_event( (int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.LEFTDOWN | (int)MouseEventFlags.LEFTUP, X, Y, 0, 0);

                //увеличиваем счетчик нажатий
                clickCount++;

                //выводим кол-во кликов
                textBox7.Text = clickCount.ToString();
                /*
                //модуль для отладки
                Console.WriteLine("ЛКМ клик");

                Console.WriteLine("Width " + SystemInformation.PrimaryMonitorSize.Width);
                Console.WriteLine("Height " + SystemInformation.PrimaryMonitorSize.Height);
                Console.WriteLine("X: " + X + "Y: " + Y);

                Console.WriteLine("ClickX " + ClickX);
                Console.WriteLine("ClickY " + ClickY);
                //модуль для отладки
                */
            }
            if (radioButton2.Checked == true)
            {
                //Перемещение курсора на указанные координаты
                mouse_event((int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.MOVE,
                    ClickX, ClickY, 0, 0);

                //Выполнение первого клика левой клавишей мыши
                mouse_event( (int)MouseEventFlags.ABSOLUTE | (int)MouseEventFlags.RIGHTDOWN | (int)MouseEventFlags.RIGHTUP, X, Y, 0, 0);

                //увеличиваем счетчик нажатий
                clickCount++;

                //выводим кол-во кликов
                textBox7.Text = clickCount.ToString();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox8.Text = "0".ToString();
            textBox6.Text = "0".ToString();
            textBox10.Text = "900".ToString();
            label18.Focus();
            
            gkh.HookedKeys.Add(Keys.Space);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUpSpace);

            gkh.HookedKeys.Add(Keys.Escape);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUpEscape);

            gkh.HookedKeys.Add(Keys.Delete);
            gkh.KeyUp += new KeyEventHandler(gkh_KeyUpDelete);
        }

        //событие обработки нажатия Delete
        private void gkh_KeyUpDelete(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                richTextBox1.Text = "";
                Array.Resize(ref massCoordX, 0);
                Array.Resize(ref massCoordY, 0);
                element = 0;
                label17.Text = element.ToString();
            }
        }

        //событие обработки нажатия ESc
        private void gkh_KeyUpEscape(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                timerClicker.Stop();
                timer.Stop();

                Console.WriteLine("Stop");

                textBox10.Enabled = true;
                textBox6.Enabled = true;
                textBox8.Enabled = true;
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

                textBox1.Text = X.ToString();
                textBox2.Text = Y.ToString();

                richTextBox1.Text += "X: " + X + " " + "Y: " + Y + "\r";

                for(int i = element; i < massCoordX.Length; i++)
                {
                    massCoordX[i] = X;
                    massCoordY[i] = Y;
                }
                element++;

                label17.Text = element.ToString();
                label18.Focus();
            }
        }

        /// <summary>
        /// A class that manages a global low level keyboard hook
        /// </summary>
        class globalKeyboardHook
        {
           
            public struct keyboardHookStruct
            {
                public int vkCode;
                public int scanCode;
                public int flags;
                public int time;
                public int dwExtraInfo;
            }

            const int WH_KEYBOARD_LL = 13;
            const int WM_KEYDOWN = 0x100;
            const int WM_KEYUP = 0x101;
            const int WM_SYSKEYDOWN = 0x104;
            const int WM_SYSKEYUP = 0x105;
           

            public List<Keys> HookedKeys = new List<Keys>();
           
            IntPtr hhook = IntPtr.Zero;
           
            public event KeyEventHandler KeyDown;
           
            public event KeyEventHandler KeyUp;

            public globalKeyboardHook()
            {
                hook();
            }

           
            ~globalKeyboardHook()
            {
                unhook();
            }

            public void hook()
            {

                IntPtr hInstance = LoadLibrary("User32");
                //hhook = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
                delegateHookProc = hookProc;
                hhook = SetWindowsHookEx(WH_KEYBOARD_LL, delegateHookProc, hInstance, 0);
            }
            public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);
            keyboardHookProc delegateHookProc;
            
            public void unhook()
            {
                UnhookWindowsHookEx(hhook);
            }

            public int hookProc(int code, int wParam, ref keyboardHookStruct lParam)
            {
                if (code >= 0)
                {
                    Keys key = (Keys)lParam.vkCode;
                    if (HookedKeys.Contains(key))
                    {
                        KeyEventArgs kea = new KeyEventArgs(key);
                        if ((wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN) && (KeyDown != null))
                        {
                            KeyDown(this, kea);
                        }
                        else
                        if ((wParam == WM_KEYUP || wParam == WM_SYSKEYUP) && (KeyUp != null))
                        {
                            KeyUp(this, kea);
                        }
                        if (kea.Handled)
                            return 1;
                    }
                }
                return CallNextHookEx(hhook, code, wParam, ref lParam);
            }
          
            [DllImport("user32.dll")]
            static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

            
            [DllImport("user32.dll")]
            static extern bool UnhookWindowsHookEx(IntPtr hInstance);

            
            [DllImport("user32.dll")]
            static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

            
            [DllImport("kernel32.dll")]
            static extern IntPtr LoadLibrary(string lpFileName);
          
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

        private void checkBox1_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                TopMost = true;
                Console.WriteLine("true");
                label18.Focus();
            }
            
            if (checkBox1.Checked == false)
            {
                TopMost = false;
                Console.WriteLine("false");
                label18.Focus();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
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
                                await sw.WriteLineAsync(textBox10.Text);

                                //клим мышки л/п
                                await sw.WriteLineAsync(radioButton1.Checked.ToString());
                                await sw.WriteLineAsync(radioButton2.Checked.ToString());

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
                                await sw.WriteLineAsync("конец");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        //интервал кликов
                        await sw.WriteLineAsync(textBox10.Text);

                        //клим мышки л/п
                        await sw.WriteLineAsync(radioButton1.Checked.ToString());
                        await sw.WriteLineAsync(radioButton2.Checked.ToString());

                        //размер массива
                        await sw.WriteLineAsync(massCoordX.Length.ToString());

                        await sw.WriteLineAsync("Xstart");
                        for (int i = 0; i < massCoordX.Length; i++)
                        {
                            await sw.WriteLineAsync(massCoordX[i].ToString());
                        }

                        await sw.WriteLineAsync("Ystart");
                        for (int i = 0; i < massCoordY.Length; i++)
                        {
                            await sw.WriteLineAsync(massCoordY[i].ToString());
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                            textBox10.Text = sr.ReadLine();
                            radioButton1.Checked = Convert.ToBoolean(sr.ReadLine());
                            radioButton2.Checked = Convert.ToBoolean(sr.ReadLine());
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
                                richTextBox1.Text += "X: " + massCoordX[i] + " " + "Y: " + massCoordY[i] + "\r";
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

        private void button3_Click(object sender, EventArgs e)
        {
            s = 0; m = 0; h = 0;
            clickCount = 0;

            countStop = Convert.ToInt32(textBox6.Text);
            timeStop = Convert.ToInt32(textBox8.Text);

            timerClicker.Interval = Convert.ToInt32(textBox10.Text);
            timerClicker.Start();

            timer.Interval = 1000;
            timer.Start();

            textBox10.Enabled = false;
            textBox6.Enabled = false;
            textBox8.Enabled = false; 
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label18.Focus();
        }
    }
}
