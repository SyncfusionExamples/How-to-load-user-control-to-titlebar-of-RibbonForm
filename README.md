# How to load user control to titlebar of RibbonForm
The RibbonForm allows to load any user control into the right side of the title bar by using the HeaderItem property.

The following code example illustrates how to add the header item in title bar of the RibbonForm.

# c#
this.button = new SfButton();
this.button.ForeColor = Color.White;
this.button.Font = Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
this.button.Size = new System.Drawing.Size(75, 50);
this.button.Text = "Sign-In";
this.button.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
this.button.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
this.button.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
this.button.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
this.button.Style.PressedForeColor = Color.White;
this.button.Style.HoverForeColor = Color.White;
this.button.Style.FocusedForeColor = Color.White;

this.HeaderItem = button;   

![Load userControl to TitleBar](Image/Load%20User%20Control%20to%20TitleBar.png)
