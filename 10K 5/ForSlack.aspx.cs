//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace _10K_5
//{
//    public partial class ForSlack : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }
//    }
//}

using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
//A simple C# class to post messages to a Slack channel  
//Note: This class uses the Newtonsoft Json.NET serializer available via NuGet  

namespace VB_Slack_Integration
{
	public class SlackClient
	{
		private readonly Uri _uri;

		private readonly Encoding _encoding = new UTF8Encoding();
		public SlackClient(string urlWithAccessToken)
		{
			_uri = new Uri(urlWithAccessToken);
		}

		//Post a message using simple strings  
		public void PostMessage(string text, string username = null, string channel = null)
		{
			Payload payload = new Payload();
			payload.Channel = channel;
			payload.Username = username;
			payload.Text = text;

			PostMessage(payload);

		}






		//Post a message using a Payload object  
		public void PostMessage(Payload payload)
		{
			string payloadJson = JsonConvert.SerializeObject(payload);

			using (WebClient client = new WebClient()) {



				NameValueCollection data = new NameValueCollection();
				data("payload") = payloadJson;



				dynamic response = client.UploadValues(_uri, "POST", data);

				//The response text is usually "ok"  
				string responseText = _encoding.GetString(response);
			}
		}
	}

	//This class serializes into the Json payload required by Slack Incoming WebHooks  
	public class Payload
	{
		[JsonProperty("channel")]
		public string Channel {
			get { return m_Channel; }
			set { m_Channel = value; }
		}

		private string m_Channel;
		[JsonProperty("username")]
		public string Username {
			get { return m_Username; }
			set { m_Username = value; }
		}

		private string m_Username;
		[JsonProperty("text")]
		public string Text {
			get { return m_Text; }
			set { m_Text = value; }
		}
		private string m_Text;
	}
}

//Slack text

public void TestPostMessage(string Msg)
{
	string urlWithAccessToken = "https://hooks.slack.com/services/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";
	//"https://adroitbureau.slack.com/services/hooks/incoming-webhook?token=https://hooks.slack.com/services/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";
	// //"https://hooks.slack.com/services/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"
	VB_Slack_Integration.SlackClient client = new VB_Slack_Integration.SlackClient(urlWithAccessToken);

	client.PostMessage(username: "The Bureau", text: Msg, channel: "#administration");
}
