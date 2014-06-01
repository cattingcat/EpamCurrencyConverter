using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TextWithCaptionControl
{
    public enum CaptionPosition { Top, Bottom, Left };

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    public class TextWithCaptionControl : WebControl, IPostBackDataHandler
    {
        public string DefaultText
        {
            get
            {
                String s = (String)ViewState["DefaultText"];
                return ((s == null)? "[" + this.ID + "]" : s);
            }
 
            set
            {
                ViewState["DefaultText"] = value;
            }
        }
        public string TextCaption
        {
            get
            {
                String s = (String)ViewState["TextCaption"];
                return ((s == null) ? "[" + this.ID + "]" : s);
            }

            set
            {
                ViewState["TextCaption"] = value;
            }
        }
        public CaptionPosition CaptionPosition
        {
            get
            {
                CaptionPosition s = (CaptionPosition)ViewState["CaptionPosition"];
                return s;
            }
            set
            {
                ViewState["CaptionPosition"] = value;
            }
        }
        public char Separator
        {
            get
            {
                char s = (char)ViewState["Separator"];
                return s;
            }
            set
            {
                ViewState["Separator"] = value;
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            Page.RegisterRequiresControlState(this);
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            writer.AddAttribute(HtmlTextWriterAttribute.Value, DefaultText);
            base.AddAttributesToRender(writer);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.RenderBeginTag(HtmlTextWriterTag.Div);

            Label defaultTextControl = new Label();
            defaultTextControl.Text = DefaultText;

            Label textCaptionControl = new Label();
            textCaptionControl.Text = TextCaption;

            if (CaptionPosition == CaptionPosition.Bottom)
            {
                this.Controls.Add(defaultTextControl);
                this.Controls.Add(new Literal() { Text = "<br/>" });
                this.Controls.Add(textCaptionControl);
                this.Controls.Add(new Literal() { Text = Separator.ToString() });
            }
            else if (CaptionPosition == CaptionPosition.Top)
            {
                this.Controls.Add(textCaptionControl);
                this.Controls.Add(new Literal() { Text = Separator.ToString() });
                this.Controls.Add(new Literal() { Text = "<br/>" });
                this.Controls.Add(defaultTextControl);                
            }
            else
            {
                this.Controls.Add(textCaptionControl);
                this.Controls.Add(new Literal() { Text = Separator.ToString() });
                this.Controls.Add(defaultTextControl);  
            }
            //this.Controls.Add(textCaptionControl);
            //this.Controls.Add(defaultTextControl);
            this.RenderChildren(writer);
            writer.RenderEndTag();

            //base.Render(writer);
        }


        public bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            return true;
        }

        public void RaisePostDataChangedEvent()
        {
        }
    }
}
