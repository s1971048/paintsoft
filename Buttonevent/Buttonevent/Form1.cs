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
    public partial class Form1 : Form
    {
        // ClickItem(どのボタンが押されたのか制御する)
        public RayerItem cRayerItem;
        // CheckItem(どのボタンが押されたのか制御する)
        public CheckItem cCheckItem;

        // panel上に作成するボタン
        public List<RayerItem> rayerButtons;// レイヤー選択ボタン
        public List<CheckItem> checkButtons;// レイヤー表示ボタン
        public List<bool> bools;// チェック状態
        public List<bool> bools2;
        public List<bool> chebls;// レイヤーの表示制御格納配列
        public List<string> rmsgs;// レイヤーにClickItemからイベントを発生させるためのリスト
        public List<string> cmsgs;// レイヤーにClickItemからイベントを発生させるためのリスト
        public List<bool> chestr2;

        public bool delbl;

        // 追加クリック数
        public int n = 0; // レイヤー選択ボタンの数
        public int clinum = 0; // レイヤー選択ボタンの枠線を制御する用の変数
        public int chenum = 0; // レイヤー表示ボタンの枠線を制御する用の変数
        public int delnum = 0; // レイヤー削除用変数

        // canvasのBitmap制御リスト
        private List<Image> bitmaps; // Bitmap格納配列
        Bitmap bitmap = null; // 差分用Bitmap
        Bitmap _bitmap = null; // 描きだし用Bitmap

        // 変数
        Color _selectedColor = Color.Black; // ペンの色

        // picbox 変数       
        bool drawFlg = false; // true:描画中

        // マウスの位置
        Point oldLocation = new Point();
        public Form1()
        {
            InitializeComponent();
            _bitmap = new Bitmap(pic.Width, pic.Height);
            rayerButtons = new List<RayerItem>(); // レイヤー選択ボタン
            checkButtons = new List<CheckItem>(); // レイヤー表示ボタン
            bools = new List<bool>(); // チェック状態
            chebls = new List<bool>();// 表示用チェック状態
            this.chestr = new List<bool>();
            rmsgs = new List<string>(); // レイヤー名制御用リスト
            cmsgs = new List<string>(); // レイヤー名制御用リスト
            bitmaps = new List<Image>(); // Bitmap格納配列
            bitmap = new Bitmap(pic.Width, pic.Height); // 差分用Bitmap
            delbl = new bool();
        }

        // 追加ボタンで、レイヤー管理
        private void Addbtn_Click(object sender, EventArgs e)
        {
            // ClickItemのインスタンスを作成
            cRayerItem = new RayerItem(this);
            // CheckItemのインスタンスを作成
            cCheckItem = new CheckItem(this);

            // 各リストに追加
            bools.Add(true);// チェックボタンの初期設定を”表示”にする
            chebls.Add(true);// チェックボタンの初期設定を”表示”にする
            rmsgs.Add(n.ToString());
            cmsgs.Add(n.ToString());
            rayerButtons.Add(cRayerItem);// インスタンスを追加
            checkButtons.Add(cCheckItem);// インスタンスを追加
            bitmaps.Add(new Bitmap(pic.Width, pic.Height)); // bitmapをリストに追加

            this.chestr.Add(true);

            // コントロールのプロパティ
            this.rayerButtons[n].Name = "OriginalButton" + n;
            this.rayerButtons[n].Text = "レイヤー" + n;
            this.checkButtons[n].Name = "Original2Button" + n;
            this.checkButtons[n].Text = "T";

            // メッセージを設定
            this.rayerButtons[n].buttonMsg = rmsgs[n];
            this.rayerButtons[n].pic = pic;
            this.checkButtons[n].buttonMsg = cmsgs[n];

            // ボタン色変更
            this.rayerButtons[n].FlatStyle = FlatStyle.Flat;
            this.rayerButtons[n].FlatAppearance.BorderColor = Color.White;
            this.rayerButtons[n].BackColor = Color.White;
            this.checkButtons[n].FlatStyle = FlatStyle.Flat;
            this.checkButtons[n].FlatAppearance.BorderColor = Color.Black;
            this.checkButtons[n].BackColor = Color.White;

            // サイズと配置
            this.rayerButtons[n].Size = new Size(100, 20);
            this.rayerButtons[n].Location = new Point(30, 10 + n * 22);
            this.checkButtons[n].Size = new Size(19, 20);
            this.checkButtons[n].Location = new Point(10, 10 + n * 22);

            // フォームへの追加
            this.rayerPanel.Controls.Add(this.rayerButtons[n]);
            this.rayerPanel.Controls.Add(this.checkButtons[n]);

            // クリック時のボタンごとのイベント動作を作成する
            this.rayerButtons[n].eventMaking();
            this.checkButtons[n].eventMaking();

            // 起動後最初に追加されたレイヤーに黒枠を付ける
            if (bitmaps.Count == 1)
                this.rayerButtons[clinum].FlatAppearance.BorderColor = Color.Black;

            
            n++;
        }
        // 削除ボタンで、レイヤー管理
        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (rayerButtons.Count > 0)
            {
                delnum = clinum;
                cCheckItem = new CheckItem(this);

                this.rayerPanel.Controls.Remove(this.rayerButtons[delnum]);
                this.rayerPanel.Controls.Remove(this.checkButtons[delnum]);

                this.chestr.RemoveAt(clinum);
                
                chebls.RemoveAt(delnum);
                rmsgs.RemoveAt(delnum);
                bitmaps.RemoveAt(delnum);
                rayerButtons.RemoveAt(delnum);
                checkButtons.RemoveAt(delnum);
                
                for (int i = 0; i < rmsgs.Count; i++)
                {
                    rmsgs[i] = i.ToString();
                    this.rayerButtons[i].buttonMsg = rmsgs[i];
                    this.checkButtons[i].buttonMsg = cmsgs[i];
                    this.rayerButtons[i].eventMaking();
                }

                for (int i = 0; i < rmsgs.Count; i++)
                {
                    this.rayerButtons[i].Location = new Point(30, 10 + i * 22);
                    this.checkButtons[i].Location = new Point(10, 10 + i * 22);
                }


                if (bitmaps.Count > 0)
                {
                    this.rayerButtons[delnum - 1].FlatStyle = FlatStyle.Flat;
                    this.rayerButtons[delnum - 1].FlatAppearance.BorderColor = Color.Black;
                }

                Draw();
                n = rmsgs.Count;
            }
        }

        public List<bool> chestr { get; set; }
        // レイヤー選択ボタンの数値を返す
        public string numClick
        {
            get
            {
                return "";
            }
            set
            {
                // クリック時に差分用bitmapを初期化
                bitmap = new Bitmap(pic.Width, pic.Height);
                // クリックボタンの押された番号
                clinum = Convert.ToInt32(value);
            }
        }
        
        // レイヤー表示ボタンの数値を返す
        public string numCheck
        {
            get
            {
                return "";
            }
            set
            {
                // チェックボタンの押された番号
                chenum = Convert.ToInt32(value);
                checkevent(chenum);
            }
        }
        
        // チェックボタンのデザイン制御
        public void checkevent(int chenum)
        {

            if (chestr[chenum] == false)
            {
                checkButtons[chenum].FlatAppearance.BorderColor = Color.Black;// チェックされたら枠線を黒に
                checkButtons[chenum].Text = "T";// チェックボタンのチェック状態のテキスト
                chestr[chenum] = true;
                blsCheck = true;
            }
            else if (chestr[chenum] == true)
            {
                checkButtons[chenum].FlatAppearance.BorderColor = Color.White;// チェックされたら枠線を白に
                checkButtons[chenum].Text = "F";// チェックボタンのチェック状態のテキスト
                chestr[chenum] = false;
                blsCheck = false;
            }
        }

        // 描画連結用メソッド
        public bool blsCheck
        {
            get
            {
                return true;
            }
            set
            {
                // cheblsにチェック状態（チェックボタン）が格納されている
                if (chebls[chenum] == true)
                    chebls[chenum] = false;
                else if(chebls[chenum] == false)
                    chebls[chenum] = true;

                //pic(ピクチャボックス)にbitmapを描き込み
                Draw();
            }
        }

        // 描画用メソッド（ペンの太さ、色、描画）
        private void draw(Graphics g, Point xy1, Point xy2)
        {
            /*
            int penWidth = 1;
            Pen pen = new Pen(_selectedColor, penWidth);
            g.DrawLine(pen, xy1, xy2);
            return;
            */

            int penWidth = Int32.Parse(trackBar1.Value.ToString());
            if (penWidth <= 1)
            {
                Pen pen = new Pen(_selectedColor, penWidth);
                g.DrawLine(pen, xy1, xy2);
                return;
            }
            Brush brush = new SolidBrush(_selectedColor);

            bool drawX = true; //true :X軸基準で描画
                               //false:Y軸基準で描画

            if (Math.Abs(xy2.X - xy1.X) >
                Math.Abs(xy2.Y - xy1.Y))
            {
                //xy2.X が大きくなるように入れ替える
                if (xy1.X > xy2.X)
                {
                    Point p = xy1;
                    xy1 = xy2;
                    xy2 = p;
                }
                drawX = true;
            }
            else
            {
                //xy2.Y が大きくなるように入れ替える
                if (xy1.Y > xy2.Y)
                {
                    Point p = xy1;
                    xy1 = xy2;
                    xy2 = p;
                }
                drawX = false;
            }

            if (drawX == true)
            {
                float y = (float)xy1.Y;

                //傾きの計算
                float a =
                    ((float)xy2.Y - xy1.Y) /
                    ((float)xy2.X - xy1.X);

                for (int x = xy1.X; x <= xy2.X; x++)
                {
                    RectangleF rect = new RectangleF(
                        x - (penWidth / 2),
                        y - (penWidth / 2),
                        penWidth,
                        penWidth);
                    g.FillEllipse(brush, rect);

                    y = y + a;
                }
            }
            else
            {
                float x = (float)xy1.X;

                //傾きの計算
                float a =
                    ((float)xy2.X - xy1.X) /
                    ((float)xy2.Y - xy1.Y);

                for (int y = xy1.Y; y <= xy2.Y; y++)
                {
                    RectangleF rect = new RectangleF(
                        x - (penWidth / 2),
                        y - (penWidth / 2),
                        penWidth,
                        penWidth);
                    g.FillEllipse(brush, rect);

                    x = x + a;
                }
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            oldLocation = e.Location;
            drawFlg = true;
            pic_MouseMove(sender, e);
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            //描画中でない場合は、処理を抜ける
            if (drawFlg == false) return;

            bitmap = new Bitmap(pic.Width, pic.Height);
            // bitmapに差分を作成
            using (Graphics g0 = Graphics.FromImage(bitmap))
            {
                draw(g0, oldLocation, e.Location);
            }
            
            // レイヤーが一つ以上あり、選択レイヤーの表示がONの場合のみ編集開始
            if (bitmaps.Count > 0 && chebls[clinum] == true)
            {
                // bitmapsに格納されているデータを差分(bitmap)で上書きする
                using (Graphics gs = Graphics.FromImage(bitmaps[clinum]))
                {
                    gs.DrawImage(bitmap, 0, 0);
                }

                //pic(ピクチャボックス)にbitmapを描き込み
                Draw();
                
                //新しい位置を保存する
                oldLocation = e.Location;
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            //描画中を解除する
            drawFlg = false;
        }

        //pic(ピクチャボックス)にbitmapを描き込み
        private void Draw()
        {
            // 現在選択されているレイヤー以外の表示可能レイヤーを表示
            Bitmap newImage = new Bitmap(pic.Width, pic.Height);
            Graphics g = Graphics.FromImage(newImage);

            // 表示許可されたbitmapのみnewImageに書き込む
            for (int i = 0; i < bitmaps.Count; i++)
                if (chebls[i] == true) g.DrawImage(bitmaps[i], 0, 0, bitmaps[i].Width, bitmaps[i].Height);

            g.Dispose();

            // ピクチャボックスに表示
            pic.Image = newImage;
        }

        private void Palette_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Palette.BackColor = colorDialog1.Color;
                _selectedColor = colorDialog1.Color;
            }
        }

        private void pen_btn_Click(object sender, EventArgs e)
        {
            _selectedColor = colorDialog1.Color;
        }

        private void era_btn_Click(object sender, EventArgs e)
        {
            _selectedColor = Color.White;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            // TrackBarの値が変更されたらラベルに表示
            label1.Text = trackBar1.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 最小値、最大値を設定
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 100;

            // 初期値を設定
            trackBar1.Value = 1;

            // 描画される目盛りの刻みを設定
            trackBar1.TickFrequency = 10;

            // スライダーをキーボードやマウス、
            // PageUp,Downキーで動かした場合の移動量設定
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 10;

            // 値が変更された際のイベントハンドらーを追加
            trackBar1.ValueChanged += new EventHandler(trackBar1_ValueChanged);
        }

        
    }
}
