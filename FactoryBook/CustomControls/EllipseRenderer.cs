﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryBook.CustomControls
{
    public class EllipseRenderer : Border
    {
        protected override void OnRender(System.Windows.Media.DrawingContext drawingContext)
        {
            Double width = this.ActualWidth;
            Double height = this.ActualHeight;
            Double a = width / 2;
            Double b = height / 2;
            Point centerPoint = new Point(a, b);
            Double thickness = this.BorderThickness.Left;
            EllipseGeometry ellipse = new EllipseGeometry(centerPoint, a, b);
            drawingContext.PushClip(ellipse);
            drawingContext.DrawGeometry(
                this.Background,
                new Pen(this.BorderBrush, thickness),
                ellipse);
        }

        protected override Size MeasureOverride(Size constraint)
        {
            return base.MeasureOverride(constraint);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            Double a = finalSize.Width / 2;
            Double b = finalSize.Height / 2;
            Double PI = 3.1415926;
            Double x = a * Math.Cos(45 * PI / 180);
            Double y = b * Math.Sin(45 * PI / 180);
            Rect rect = new Rect(new Point(a - x, b - y), new Point(a + x, b + y));
            if (base.Child != null)
            {
                base.Child.Arrange(rect);
            }

            return finalSize;
        }
    }
}