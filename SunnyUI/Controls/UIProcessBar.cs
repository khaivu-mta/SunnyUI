﻿/******************************************************************************
 * SunnyUI 开源控件库、工具类库、扩展类库、多页面开发框架。
 * CopyRight (C) 2012-2021 ShenYongHua(沈永华).
 * QQ群：56829229 QQ：17612584 EMail：SunnyUI@QQ.Com
 *
 * Blog:   https://www.cnblogs.com/yhuse
 * Gitee:  https://gitee.com/yhuse/SunnyUI
 * GitHub: https://github.com/yhuse/SunnyUI
 *
 * SunnyUI.dll can be used for free under the GPL-3.0 license.
 * If you use this code, please keep this note.
 * 如果您使用此代码，请保留此说明。
 ******************************************************************************
 * 文件名称: UIProcessBar.cs
 * 文件说明: 进度条
 * 当前版本: V3.0
 * 创建日期: 2020-01-01
 *
 * 2020-01-01: V2.2.0 增加文件说明
 * 2020-04-19: V2.2 增加数值变化事件
******************************************************************************/

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Sunny.UI
{
    [ToolboxItem(true)]
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Value")]
    public sealed class UIProcessBar : UIControl
    {
        private int maximum = 100;

        public delegate void OnValueChanged(object sender, int value);

        public event OnValueChanged ValueChanged;

        public UIProcessBar()
        {
            SetStyleFlags(true, false);
            MinimumSize = new Size(70, 5);
            Size = new Size(300, 29);
            ShowText = false;

            fillColor = UIColor.LightBlue;
            foreColor = UIColor.Blue;
        }
        private UILine.LineDirection direction = UILine.LineDirection.Horizontal;

        [DefaultValue(UILine.LineDirection.Horizontal)]
        [Description("线条方向"), Category("SunnyUI")]
        public UILine.LineDirection Direction
        {
            get => direction;
            set
            {
                if (direction != value)
                {
                    direction = value;
                    Invalidate();
                }
            }
        }

        [DefaultValue(100)]
        [Description("最大值"), Category("SunnyUI")]
        public int Maximum
        {
            get => maximum;
            set
            {
                maximum = value;
                Invalidate();
            }
        }

        private int posValue;

        [DefaultValue(0)]
        [Description("当前位置"), Category("SunnyUI")]
        public int Value
        {
            get => posValue;
            set
            {
                posValue = Math.Max(value, 0);
                posValue = Math.Min(posValue, maximum);
                ValueChanged?.Invoke(this, posValue);
                Invalidate();
            }
        }

        private bool showValue = true;

        [DefaultValue(true)]
        [Description("显示进度值"), Category("SunnyUI")]
        public bool ShowValue
        {
            get => showValue;
            set
            {
                showValue = value;
                Invalidate();
            }
        }

        [DefaultValue(1)]
        [Description("步进值"), Category("SunnyUI")]
        public int Step { get; set; } = 1;

        public void StepIt()
        {
            Value = Math.Min(Value + Step, Maximum);
        }

        private Bitmap image;
        private int imageRadius;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            float processSize;
            string processText = "0.0%";

            if (Direction == UILine.LineDirection.Horizontal)
                processSize = posValue * Width * 1.0f / Maximum;
            else
                processSize = posValue * Height * 1.0f / Maximum;

            if (ShowPercent)
                processText = (posValue * 100.0 / maximum).ToString("F" + DecimalCount) + "%";
            else
                processText = (posValue * 1.0 / maximum).ToString("F" + DecimalCount);

            SizeF sf = e.Graphics.MeasureString(processText, Font);
            bool canShow = Height > sf.Height + 4;

            if (ShowValue && canShow)
            {
                e.Graphics.DrawString(processText, Font, foreColor, Size, Padding, TextAlign);
            }

            if (image == null || image.Width != Width || image.Height != Height || imageRadius != Radius)
            {
                image?.Dispose();
                image = new Bitmap(Width, Height);
                imageRadius = Radius;
            }

            Graphics g = image.Graphics();
            g.Clear(Color.Transparent);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            g.SetHighQuality();
            g.FillRoundRectangle(rectColor, rect, Radius);
            g.DrawRoundRectangle(rectColor, rect, Radius);
            if (ShowValue && canShow)
            {
                g.DrawString(processText, Font, fillColor, Size, Padding, TextAlign);
            }

            g.Dispose();

            if (Direction == UILine.LineDirection.Horizontal)
            {
                e.Graphics.DrawImage(image,
                    new RectangleF(0, 0, processSize, image.Height),
                    new RectangleF(0, 0, processSize, image.Height),
                    GraphicsUnit.Pixel);
            }
            else
            {
                e.Graphics.DrawImage(image,
                    new RectangleF(0, image.Height - processSize, image.Width, processSize),
                    new RectangleF(0, image.Height - processSize, image.Width, processSize),
                    GraphicsUnit.Pixel);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        private bool showPercent = true;

        [Description("显示文字百分比"), Category("SunnyUI")]
        [DefaultValue(true)]
        public bool ShowPercent
        {
            get => showPercent;
            set
            {
                showPercent = value;
                Invalidate();
            }
        }

        private int decimalCount = 1;

        [Description("显示文字小数位数"), Category("SunnyUI")]
        [DefaultValue(1)]
        public int DecimalCount
        {
            get => decimalCount;
            set => decimalCount = Math.Max(value, 0);
        }

        public override void SetStyleColor(UIBaseStyle uiColor)
        {
            base.SetStyleColor(uiColor);
            fillColor = uiColor.ProcessBarFillColor;
            foreColor = uiColor.ProcessBarForeColor;
            Invalidate();
        }

        /// <summary>
        /// 填充颜色，当值为背景色或透明色或空值则不填充
        /// </summary>
        [Description("填充颜色"), Category("SunnyUI")]
        [DefaultValue(typeof(Color), "235, 243, 255")]
        public Color FillColor
        {
            get => fillColor;
            set => SetFillColor(value);
        }

        /// <summary>
        /// 字体颜色
        /// </summary>
        [Description("字体颜色"), Category("SunnyUI")]
        [DefaultValue(typeof(Color), "80, 160, 255")]
        public override Color ForeColor
        {
            get => foreColor;
            set => SetForeColor(value);
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        [Description("边框颜色"), Category("SunnyUI")]
        [DefaultValue(typeof(Color), "80, 160, 255")]
        public Color RectColor
        {
            get => rectColor;
            set => SetRectColor(value);
        }
    }
}