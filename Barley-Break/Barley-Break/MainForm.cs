using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Barley_Break
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
			
			step    = 0;
			seconds = 0;
			started = false;
			
            CreateField();
        }
        
        Button[,] buttons;
        int       step;
        int       seconds;
        bool      started;
		
        void CreateField()
        {
            buttons           = new Button[4, 4];
            const int margin  = 40;
            int serial_number = 0;
            for (int i = 0; i <  Math.Sqrt(buttons.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(buttons.Length); j++)
                {
                    buttons[i, j] = new Button()
                    {
                        Name      = "button" + ++serial_number,
                        Text      = serial_number.ToString(),
                        Font      = new Font("Showcard Gothic", 33),
                        Size      = new Size(80, 80),
                        BackColor = Color.Gold,
                        ForeColor = Color.Maroon,
                        FlatStyle = FlatStyle.Flat,
                    };
                    buttons[i, j].FlatAppearance.BorderSize         = 1;
                    buttons[i, j].FlatAppearance.BorderColor        = Color.Maroon;
                    buttons[i, j].FlatAppearance.MouseOverBackColor = Color.Khaki;
                    buttons[i, j].Location                          = new Point(buttons[i, j].Width * j + margin,
                                                                                buttons[i, j].Height * i + margin * 2);
                    buttons[i, j].Click                            += Button_Click;

                    if (buttons[i, j].Text == buttons.Length.ToString())
                    {
                        buttons[i, j].Visible = false;
                    }

                    Controls.Add(buttons[i, j]);
                }
            }
        }

        void NewGame()
        {
            List<int> numbers = new List<int>(buttons.Length);
            Random rand       = new Random();
            foreach (Button button in buttons)
            {
                        button.Visible = true;
              GENERATE: int number     = rand.Next(1, buttons.Length + 1);
						if (numbers.Contains(number))
						{
							goto GENERATE;
						}
						else
						{
							numbers.Add(number);
							button.Text = number.ToString();
							if (button.Text == buttons.Length.ToString())
							{
								button.Visible = false;
							}
						}
            }
			
            step          = 0;
            steps.Text    = "Steps: 0";
			
            seconds       = 0;
            time.Text     = "Time: 0";
			
            timer.Enabled = true;
            started       = true;
        }

        void Solve()
        {
            if (started)
            {
                int number = 0;
                foreach (Button button in buttons)
                {
                    button.Visible = true;
                    button.Text    = (++number).ToString();
                    if (button.Text == buttons.Length.ToString())
                    {
                        button.Visible = false;
                    }
                }
                Win();
            }
            else
            {
                return;
            }
        }

        void Win()
        {
            int count = 0;
            foreach (Button button in buttons)
            {
                if (button.Text == button.Name.Substring(6))
                {
                    count++;
                    if (count == buttons.Length)
                    {
                        timer.Enabled = false;
                        started = false;
                        MessageBox.Show(this, "Gongratulations, you have solved this puzzle!", 
                                        Application.ProductName, 
                                        MessageBoxButtons.OK, 
                                        MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        void Button_Click(object sender, EventArgs e)
        {
            if (!started)
			{
				return;
			}
			
            Button clicked    = sender as Button;
            int serial_number = int.Parse(clicked.Name.Substring(6));
            foreach (Button neighbor in buttons)
            {
                if (neighbor.Name == "button" + (serial_number + 1)                          ||
                    neighbor.Name == "button" + (serial_number - 1)                          ||
                    neighbor.Name == "button" + (serial_number + Math.Sqrt(buttons.Length))  ||
                    neighbor.Name == "button" + (serial_number - Math.Sqrt(buttons.Length)))
                {
                    if (neighbor.Visible == false)
                    {
                        neighbor.Visible = true;
                        neighbor.Text    = clicked.Text;
                        neighbor.Focus();
                        clicked.Visible  = false;
                        clicked.Text     = buttons.Length.ToString();
                        steps.Text       = "Steps: " + (++step).ToString();
                        timer.Enabled    = true;
                    }
                }
            }
        }

        void Solve_Click(object sender, EventArgs e)
        {
            Solve();
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            time.Text = "Time: " + (++seconds).ToString();
            Win();
        }

        void NewGameMenuStrip_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        void ExitMenuStrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}