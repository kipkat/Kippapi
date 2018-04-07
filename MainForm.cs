using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kippapi
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			button2.Text="Check";
			try
			{
				richTextBox2.Text="";
				if (!textBox1.Text.Contains("https://"))
				{
					if (!textBox1.Text.Contains("http://")) textBox1.Text="http://"+textBox1.Text;
				}
				string api = new System.Net.WebClient().DownloadString(textBox1.Text);
				richTextBox1.Text=api;
				if (richTextBox1.Text.Contains("true"))
				{
					richTextBox2.Text+="True boolean detected. ";
				}
				if (richTextBox1.Text.Contains("\"content\""))
				{
					richTextBox2.Text+="Content boxes. ";
				}
				if (richTextBox1.Text.Contains("style"))
				{
					richTextBox2.Text+="Style found. ";
				}
				if (richTextBox1.Text.Contains("<--"))
				{
					richTextBox2.Text+="Comments. ";
				}
				if (richTextBox1.Text.Contains("type=\"password\""))
				{
					richTextBox2.Text+="Passwords. ";
				}
				if (richTextBox1.Text.Contains("detector"))
				{
					richTextBox2.Text+="Detector found. ";
				}
				if (richTextBox1.Text.Contains("language=\"javascript\""))
				{
					richTextBox2.Text+="Javascript scripts. ";
				}
				if (richTextBox1.Text.Contains("<script>"))
				{
					richTextBox2.Text+="Scripts. ";
				}
				if (richTextBox1.Text.Contains("alert("))
				{
					richTextBox2.Text+="Alert boxes. ";
				}
				if (richTextBox1.Text.Contains("ads"))
				{
					richTextBox2.Text+="Ads detected! ";
				}
				if (richTextBox1.Text.Contains("youtube"))
				{
					richTextBox2.Text+="Youtube video. ";
				}
				if (richTextBox1.Text.Contains("google"))
				{
					richTextBox2.Text+="Google services. ";
				}
				if (richTextBox1.Text.Contains("service"))
				{
					richTextBox2.Text+="Services. ";
				}
				if (richTextBox1.Text.Contains(".onion"))
				{
					richTextBox2.Text+="Deep-web links. ";
				}
				if (richTextBox1.Text.Contains("simulator"))
				{
					richTextBox2.Text+="Simulation found. ";
				}
				if (richTextBox1.Text.Contains("secret"))
				{
					richTextBox2.Text+="Secrets found. ";
				}
				if (richTextBox1.Text.Contains("wiki"))
				{
					richTextBox2.Text+="Wiki services. ";
				}
				if (richTextBox1.Text.Contains("adb"))
				{
					richTextBox2.Text+="Adblocker services. ";
				}
				if (richTextBox1.Text.Contains(".exe")){richTextBox2.Text+="Exe files found. ";}
				if (richTextBox1.Text.Contains("../")){richTextBox2.Text+="Reverse directory found. ";}
				if (richTextBox1.Text.Contains("0x")){richTextBox2.Text+="Hex values found. ";}
				if (richTextBox1.Text.Contains("test")){richTextBox2.Text+="Testing content detected. ";}
				if (richTextBox1.Text.Contains("window")){richTextBox2.Text+="Window changer detected! ";}
				if (richTextBox1.Text.Contains("color")){richTextBox2.Text+="Color values found. ";}
				if (richTextBox1.Text.Contains("log")){richTextBox2.Text+="Logs found. ";}
				if (richTextBox1.Text.Contains("666")){richTextBox2.Text+="Satanic messages detected! ";}
				if (richTextBox1.Text.Contains("satan")){richTextBox2.Text+="Satan detected! ";}
				if (richTextBox1.Text.Contains("email")){richTextBox2.Text+="Email field found. ";}
				if (richTextBox1.Text.Contains("mail")){richTextBox2.Text+="Mail field found. ";}
				if (richTextBox1.Text.Contains("api")){richTextBox2.Text+="Api detected! ";}
				if (richTextBox1.Text.Contains("parameter")){richTextBox2.Text+="Parameters detected! ";}
				if (richTextBox1.Text.Contains("argument")){richTextBox2.Text+="Arguments detected! ";}
				if (richTextBox1.Text.Contains("game")){richTextBox2.Text+="Games detected! ";}
				if (richTextBox1.Text.Contains("comment")){richTextBox2.Text+="Public user comments detected! ";}
				if (richTextBox1.Text.Contains("xss")){richTextBox2.Text+="XSS fields! ";}
				if (richTextBox1.Text.Contains("sql")){richTextBox2.Text+="SQL actions detected! ";}
				if (richTextBox1.Text.Contains("database")){richTextBox2.Text+="Database detected! ";}
				if (richTextBox1.Text.Contains("db")){richTextBox2.Text+="Hidden database detected! ";}
				if (richTextBox1.Text.Contains("opyright")){richTextBox2.Text+="Copyright detected! ";}
				if (richTextBox1.Text.Contains("debug")){richTextBox2.Text+="Debug actions found. ";}
				if (richTextBox1.Text.Contains("button")){richTextBox2.Text+="Buttons found. ";}
				if (richTextBox1.Text.Contains("toggle")){richTextBox2.Text+="Toggle elements found. ";}
				if (richTextBox1.Text.Contains("www")){richTextBox2.Text+="WWW Server found. ";}
				if (richTextBox1.Text.Contains("music")){richTextBox2.Text+="Music elements found. ";}
				if (richTextBox1.Text.Contains("404")){richTextBox2.Text+="Server not found value. ";}
				if (richTextBox1.Text.Contains("cookie")){richTextBox2.Text+="Cookies found. ";}
				if (richTextBox1.Text.Contains("like")){richTextBox2.Text+="Like-Counter detected. ";}
				if (richTextBox1.Text.Contains("dislike")){richTextBox2.Text+="Dislike-Counter detected. ";}
				if (richTextBox1.Text.Contains("counter")){richTextBox2.Text+="Counter detected. ";}
				if (richTextBox1.Text.Contains("var ")){richTextBox2.Text+="Unexpected variable definitions. ";}
				if (richTextBox1.Text.Contains("type")){richTextBox2.Text+="Types elements found. ";}
				if (richTextBox1.Text.Contains("javascript:")){richTextBox2.Text+="Forced javascript conversion detected! ";}
				if (richTextBox1.Text.Contains("analytics")){richTextBox2.Text+="Analytics elements found!!! ";}
				if (richTextBox1.Text.Contains("login")){richTextBox2.Text+="Login detected!!! ";}
				if (richTextBox1.Text.Contains("id=")){richTextBox2.Text+="ID export found!!! ";}
				if (richTextBox1.Text.Contains("expert")){richTextBox2.Text+="Solution found!!! ";}
				if (richTextBox1.Text.Contains("algorithm")){richTextBox2.Text+="Algorithms found!!! ";}
				if (richTextBox1.Text.Contains("hacked")){richTextBox2.Text+="DEFACED PAGE SOURCE!!! ";}
				if (richTextBox1.Text.Contains("pwd")){richTextBox2.Text+="Hidden password found!!! ";}
				if (richTextBox1.Text.Contains("()")){richTextBox2.Text+="Non-argument functions detected!!! ";}
				if (richTextBox1.Text.Contains("time")){richTextBox2.Text+="Time set detected!!! ";}
				if (richTextBox1.Text.Contains("trace")){richTextBox2.Text+="Tracing methods found!!! ";}
				if (richTextBox1.Text.Contains("secured")){richTextBox2.Text+="Secured elements found!!! ";}
				if (richTextBox1.Text.Contains("\"\"")){richTextBox2.Text+="Null string detected! ";}
				if (richTextBox1.Text.Contains("tor")){richTextBox2.Text+="Tor browser detector found! ";}
				if (richTextBox1.Text.Contains("anonymous")){richTextBox2.Text+="Anonymous detector found!!! ";}
				if (richTextBox1.Text.Contains("directx")){richTextBox2.Text+="Directx scanner found!!! ";}
				if (richTextBox1.Text.Contains("webgl")){richTextBox2.Text+="WebGL scripts found!!! ";}
				if (richTextBox1.Text.Contains("map")){richTextBox2.Text+="Maps found!!! ";}
				if (richTextBox1.Text.Contains("set")){richTextBox2.Text+="Settings found!!! ";}
				if (richTextBox1.Text.Contains("/*")){richTextBox2.Text+="Style comment! ";}
				if (richTextBox1.Text.Contains("<!--")){richTextBox2.Text+="Comment1 found!!! ";}
				if (richTextBox1.Text.Contains("<--")){richTextBox2.Text+="Comment2 found!!! ";}
				if (richTextBox1.Text.Contains("42")){richTextBox2.Text+="Life number found!!! ";}
				if (richTextBox1.Text.Contains("00")){richTextBox2.Text+="Double null found!!! ";}
				if (richTextBox1.Text.Contains("useless")){richTextBox2.Text+="Useless elements found!!! ";}
				if (richTextBox1.Text.Contains("\">")){richTextBox2.Text+="XSS escape methods found!!! ";}
				if (richTextBox1.Text.Contains("market")){richTextBox2.Text+="Market found!!! ";}
			}
			catch
			{
				richTextBox1.Text="Error";
				richTextBox2.Text="Error";
			}
		}
		void checkelement(object sender, System.EventArgs e)
		{
			if (richTextBox1.Text.Contains(textBox2.Text)){
				button2.Text="True. Check";
			}
			else button2.Text="False. Check";
		}
	}
}
