using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buttonevent
{
    public partial class CheckItem : Button
    {
        //Form1 cForm1;
        Form1 cForm1;
        int chenum;
        public CheckItem(Form1 cForm1)
        {
            // cForm1のインスタンスを作成
            this.cForm1 = cForm1;
        }
        // ボタンを押して表示される文言テキスト
        public string buttonMsg { get; set; }
        
        // ボタンへのイベントをセットする
        public void eventMaking()
        {
            this.Click += new EventHandler(doClickEvent);
        }
        // ボタンへのイベントを解除する
        public void eventSuspend()
        {
            this.Click -= new EventHandler(doClickEvent);
        }

        // クリックイベントの実体(参照するリストボ ックスに文言テキストを追加)
        public void doClickEvent(object sender, EventArgs e)
        {
            chenum = Convert.ToInt32(buttonMsg);
            cForm1.numCheck = buttonMsg;            
        }
    }
}