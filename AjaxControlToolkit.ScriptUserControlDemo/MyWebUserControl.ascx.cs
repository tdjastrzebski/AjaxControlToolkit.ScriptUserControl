// author: Tomasz Jastrzębski

using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Web.UI;

[assembly: WebResource("AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl.js", "application/x-javascript")]

// Note: Instead of embedding and declaring script can be registered using:
// ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl", ResolveClientUrl("~/MyWebUserControl.js"));

namespace AjaxControlToolkit.ScriptUserControlDemo
{
	[ClientScriptResource("AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl", "AjaxControlToolkit.ScriptUserControlDemo.MyWebUserControl")]
	public partial class MyWebUserControl : ScriptUserControl
	{
		private System.Drawing.Point _location;

		// enables Client State
		public MyWebUserControl() : base(true, HtmlTextWriterTag.Div) { }

		[ExtenderControlProperty]
		[ClientPropertyName("panelID")]
		public string PanelID {
			get { EnsureID(); return Panel1.ClientID; }
		}

		#region [ IClientStateManager ]
		protected override void LoadClientState(string clientState)
		{
			Dictionary<string, object> state = (Dictionary<string, object>)new JavaScriptSerializer().DeserializeObject(clientState);
			if (state != null) {
				_location.X = (int)state["X"];
				_location.Y = (int)state["Y"];
			}
		}
		protected override string SaveClientState()
		{
			Dictionary<string, object> state = new Dictionary<string, object>();
			state["X"] = _location.X;
			state["Y"] = _location.Y;
			return new JavaScriptSerializer().Serialize(state);
		}
		#endregion

		protected void Button1_Click(object sender, EventArgs e)
		{
			Label1.Text = "server time:" + DateTime.Now.ToLongTimeString();
			Label2.Text = "notice control position is maintained across postbacks";
		}
	}
}
