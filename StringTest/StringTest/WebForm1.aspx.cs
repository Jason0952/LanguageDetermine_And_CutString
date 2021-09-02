using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StringTest
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load( object sender, EventArgs e )
		{
			Label1.Text = "您對哪項產品感興趣？,aaaa:::應用,bbbb,:::您是從哪裡得知產品訊息的？,cccc,,";
			Label2.Text = "Which products are you interested?,aaaa,bbbb,cccc,:::Application,aabb,bbcc,ccdd,ddee,eeff,ffgg,Other,other測試:::Where do you learn our product from?,abab,bcbc,cdcd,dede,Other,other測試";
			Label3.Text = "中文";
			Label6.Text = "英文";
		}

		protected void Button1_Click( object sender, EventArgs e )
		{
			stringtest(Label1.Text);
			stringtest2(Label2.Text);
		}

		private void stringtest( string LabelTest )
		{
			string Interested_Product = "";
			string Interested_Product_Other = "";
			string Application = "";
			string Application_Other = "";
			string Info_From = "";
			string Info_From_Other = "";

			string[] Inquiry = LabelTest.Replace(":::", ":").Split(':');

			string[] First_Inquiry = Inquiry[0].Split(',');
			string[] Second_Inquiry = Inquiry[1].Split(',');
			string[] Third_Inquiry = Inquiry[2].Split(',');

			if ( !Regex.IsMatch(Inquiry[0].Split(',')[0], @"[\u4e00-\u9fa5]") )
			{
				if ( Inquiry[0].Contains("other") )
				{
					Interested_Product_Other = First_Inquiry[First_Inquiry.Length - 1];

					for ( int i = 1 ; i < First_Inquiry.Length - 1 ; i++ )
					{
						Interested_Product += First_Inquiry[i].ToString() + ",";
					}
				}
				else
				{
					for ( int i = 1 ; i < First_Inquiry.Length ; i++ )
					{
						Interested_Product += First_Inquiry[i].ToString() + ",";
					}
				}

				if ( Inquiry[1].Contains("other") )
				{
					Application_Other = Second_Inquiry[Second_Inquiry.Length - 1];

					for ( int i = 1 ; i < Second_Inquiry.Length - 1 ; i++ )
					{
						Application += Second_Inquiry[i].ToString() + ",";
					}
				}
				else
				{
					for ( int i = 1 ; i < Second_Inquiry.Length ; i++ )
					{
						Application += Second_Inquiry[i].ToString() + ",";
					}
				}

				if ( Inquiry[2].Contains("other") )
				{

					Info_From_Other = Third_Inquiry[Third_Inquiry.Length - 1];

					for ( int i = 1 ; i < Third_Inquiry.Length - 1 ; i++ )
					{
						Info_From += Third_Inquiry[i].ToString() + ",";
					}
				}
				else
				{
					for ( int i = 1 ; i < Third_Inquiry.Length ; i++ )
					{
						Info_From += Third_Inquiry[i].ToString() + ",";
					}
				}
			}
			else
			{
				for ( int i = 1 ; i < First_Inquiry.Length ; i++ )
				{
					Interested_Product += First_Inquiry[i].ToString() + ",";
				}

				for ( int i = 1 ; i < Second_Inquiry.Length ; i++ )
				{
					Application += Second_Inquiry[i].ToString() + ",";
				}

				for ( int i = 1 ; i < Third_Inquiry.Length ; i++ )
				{
					Info_From += Third_Inquiry[i].ToString() + ",";
				}
			}

			Label4.Text = string.Format("Inquiry[0] : {0}<br>Inquiry[1] : {1}<br>Inquiry[2] : {2}", Inquiry[0], Inquiry[1], Inquiry[2]);
			Label5.Text = string.Format("Interested_Product : {0}<br>Interested_Product_Other : {1}<br>Application : {2}<br>Application_Other : {3}<br>Info_From : {4}<br>Info_From_Other : {5}", Interested_Product, Interested_Product_Other, Application, Application_Other, Info_From, Info_From_Other);
			Label4.Visible = true;
			Label5.Visible = true;
		}

		private void stringtest2( string LabelTest )
		{
			string Interested_Product = "";
			string Interested_Product_Other = "";
			string Application = "";
			string Application_Other = "";
			string Info_From = "";
			string Info_From_Other = "";

			string[] Inquiry = LabelTest.Replace(":::", ":").Split(':');

			string[] First_Inquiry = Inquiry[0].Split(',');
			string[] Second_Inquiry = Inquiry[1].Split(',');
			string[] Third_Inquiry = Inquiry[2].Split(',');

			if ( !Regex.IsMatch(Inquiry[0].Split(',')[0], @"[\u4e00-\u9fa5]") )
			{
				if ( Inquiry[0].Contains("other") )
				{
					Interested_Product_Other = First_Inquiry[First_Inquiry.Length - 1];

					for ( int i = 1 ; i < First_Inquiry.Length - 1 ; i++ )
					{
						Interested_Product += First_Inquiry[i].ToString() + ",";
					}
				}
				else
				{
					for ( int i = 1 ; i < First_Inquiry.Length ; i++ )
					{
						Interested_Product += First_Inquiry[i].ToString() + ",";
					}
				}

				if ( Inquiry[1].Contains("other") )
				{
					Application_Other = Second_Inquiry[Second_Inquiry.Length - 1];

					for ( int i = 1 ; i < Second_Inquiry.Length - 1 ; i++ )
					{
						Application += Second_Inquiry[i].ToString() + ",";
					}
				}
				else
				{
					for ( int i = 1 ; i < Second_Inquiry.Length ; i++ )
					{
						Application += Second_Inquiry[i].ToString() + ",";
					}
				}

				if ( Inquiry[2].Contains("other") )
				{

					Info_From_Other = Third_Inquiry[Third_Inquiry.Length - 1];

					for ( int i = 1 ; i < Third_Inquiry.Length - 1 ; i++ )
					{
						Info_From += Third_Inquiry[i].ToString() + ",";
					}
				}
				else
				{
					for ( int i = 1 ; i < Third_Inquiry.Length ; i++ )
					{
						Info_From += Third_Inquiry[i].ToString() + ",";
					}
				}
			}
			else
			{
				for ( int i = 1 ; i < First_Inquiry.Length ; i++ )
				{
					Interested_Product += First_Inquiry[i].ToString() + ",";
				}

				for ( int i = 1 ; i < Second_Inquiry.Length ; i++ )
				{
					Application += Second_Inquiry[i].ToString() + ",";
				}

				for ( int i = 1 ; i < Third_Inquiry.Length ; i++ )
				{
					Info_From += Third_Inquiry[i].ToString() + ",";
				}
			}

			Label7.Text = string.Format("Inquiry[0] : {0}<br>Inquiry[1] : {1}<br>Inquiry[2] : {2}", Inquiry[0], Inquiry[1], Inquiry[2]);
			Label8.Text = string.Format("Interested_Product : {0}<br>Interested_Product_Other : {1}<br>Application : {2}<br>Application_Other : {3}<br>Info_From : {4}<br>Info_From_Other : {5}", Interested_Product, Interested_Product_Other, Application, Application_Other, Info_From, Info_From_Other);
			Label7.Visible = true;
			Label8.Visible = true;
		}
	}
}