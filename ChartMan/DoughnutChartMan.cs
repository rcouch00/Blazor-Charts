﻿using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.man.svg;

namespace DoughnutChartComponent
{
    public class DoughnutChartMan :BlazorComponent
    {

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            var seq = 0;
            builder.OpenElement(seq, "figure");
            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "doughnut-main");

            SVG svg = new SVG() { { "width", "100%" }, { "height", "100%" }, { "viewBox", "0 0 42 42" } };
            Rectangle rect = new Rectangle() { { "width", "100%" }, { "height", "100%" }, { "fill", "white" } };
            Circle hole = new Circle() { { "cx", "21" }, { "cy", "21" }, { "r", "15.915" }, { "fill", "#fff" } };
            Circle ring = new Circle() { { "cx", "21" }, { "cy", "21" }, { "r", "15.915" }, { "fill", "transparent" }, { "stroke-width", "3" }, { "stroke", "#d2d3d4" }};
            Circle segment1 = new Circle() { { "cx", "21" }, { "cy", "21" }, { "r", "15.915" }, { "fill", "transparent" }, { "stroke-width", "5" }, { "stroke", "#ce4b99" },{ "stroke-dasharray", "40 60" }, { "stroke-dashoffset", "25" } };
            Circle segment2 = new Circle() { { "cx", "21" }, { "cy", "21" }, { "r", "15.915" }, { "fill", "transparent" }, { "stroke-width", "5" }, { "stroke", "#377bbc" },{ "stroke-dasharray", "20 80" }, { "stroke-dashoffset", "85" } };
            Circle segment3 = new Circle() { { "cx", "21" }, { "cy", "21" }, { "r", "15.915" }, { "fill", "transparent" }, { "stroke-width", "5" }, { "stroke", "#27A844" },{ "stroke-dasharray", "40 60" }, { "stroke-dashoffset", "65" } };
            Text numberText = new Text() { { "x", "50%" }, { "y", "50%" }, { "class", "doughnut-number" }, { "content", "100" } };
            Text labelText = new Text() { { "x", "50%" }, { "y", "50%" }, { "class", "doughnut-label" }, { "content", "Sales" } };
            Group grp = new Group() { { "class", "doughnut-text" } };
            grp.AddItems(numberText,labelText);
            svg.AddItems(rect, hole, ring, segment1, segment2, segment3, grp);

            BlazorRenderer blazorRenderer = new BlazorRenderer();
            blazorRenderer.Draw(seq, builder, svg);

            builder.OpenElement(++seq, "figcaption");
            builder.AddAttribute(++seq, "class", "doughnut-key");
            builder.OpenElement(++seq, "ul");
            builder.AddAttribute(++seq, "class", "doughnut-key-list");
            builder.AddAttribute(++seq, "aria-hidden", "true");
            builder.AddAttribute(++seq, "style", "list-style-type: none;");

            builder.OpenElement(++seq, "li");
            builder.OpenElement(++seq, "span");
            builder.AddAttribute(++seq, "class", "round-dot dot-red");
            builder.CloseElement();
            builder.AddContent(++seq, "App Store (40)");
            builder.CloseElement();

            builder.OpenElement(++seq, "li");
            builder.OpenElement(++seq, "span");
            builder.AddAttribute(++seq, "class", "round-dot dot-green");
            builder.CloseElement();
            builder.AddContent(++seq, "Website (20)");
            builder.CloseElement();

            builder.OpenElement(++seq, "li");
            builder.OpenElement(++seq, "span");
            builder.AddAttribute(++seq, "class", "round-dot dot-blue");
            builder.CloseElement();
            builder.AddContent(++seq, "Partners (40)");
            builder.CloseElement();

            builder.CloseElement();
            builder.CloseElement();

            builder.CloseElement();
            builder.CloseElement();

 
            /*
            builder.OpenElement(seq, "figure");
            builder.OpenElement(++seq, "div");
            builder.AddAttribute(++seq, "class", "doughnut-main");

            builder.OpenElement(++seq, "svg");
            builder.AddAttribute(++seq, "width", "100%");
            builder.AddAttribute(++seq, "height", "100%");
            builder.AddAttribute(++seq, "viewBox", "0 0 42 42");

            builder.OpenElement(++seq, "rect");
            builder.AddAttribute(++seq, "width", "100%");
            builder.AddAttribute(++seq, "height", "100%");
            builder.AddAttribute(++seq, "fill", "white");
            builder.CloseElement();

            builder.OpenElement(++seq, "circle");
            builder.AddAttribute(++seq, "class", "hole");
            builder.AddAttribute(++seq, "cx", "21");
            builder.AddAttribute(++seq, "cy", "21");
            builder.AddAttribute(++seq, "r", "15.91549430918954");
            builder.AddAttribute(++seq, "fill", "#fff");
            builder.CloseElement();

            builder.OpenElement(++seq, "circle");
            builder.AddAttribute(++seq, "cx", "21");
            builder.AddAttribute(++seq, "cy", "21");
            builder.AddAttribute(++seq, "r", "15.91549430918954");
            builder.AddAttribute(++seq, "fill", "transparent");
            builder.AddAttribute(++seq, "stroke", "#d2d3d4");
            builder.AddAttribute(++seq, "stroke-width", "3");
            builder.CloseElement();

            builder.OpenElement(++seq, "circle");
                builder.AddAttribute(++seq, "cx", "21");
                builder.AddAttribute(++seq, "cy", "21");
                builder.AddAttribute(++seq, "r", "15.91549430918954");
                builder.AddAttribute(++seq, "fill", "transparent");
                builder.AddAttribute(++seq, "stroke", "#ce4b99");
                builder.AddAttribute(++seq, "stroke-width", "5");
                builder.AddAttribute(++seq, "stroke-dasharray", "40 60");
                builder.AddAttribute(++seq, "stroke-dashoffset", "25");
                builder.OpenElement(++seq, "title");
                    builder.AddContent(++seq, "App Store");
                builder.CloseElement();
                builder.OpenElement(++seq, "desc");
                    builder.AddContent(++seq, "40% (40 out of 100)");
                builder.CloseElement();
            builder.CloseElement();

            builder.OpenElement(++seq, "circle");
            builder.AddAttribute(++seq, "cx", "21");
            builder.AddAttribute(++seq, "cy", "21");
            builder.AddAttribute(++seq, "r", "15.91549430918954");
            builder.AddAttribute(++seq, "fill", "transparent");
            builder.AddAttribute(++seq, "stroke", "#27A844");
            builder.AddAttribute(++seq, "stroke-width", "5");
            builder.AddAttribute(++seq, "stroke-dasharray", "20 80");
            builder.AddAttribute(++seq, "stroke-dashoffset", "85");
            builder.OpenElement(++seq, "title");
            builder.AddContent(++seq, "Website");
            builder.CloseElement();
            builder.OpenElement(++seq, "desc");
            builder.AddContent(++seq, "20% (20 out of 100)");
            builder.CloseElement();
            builder.CloseElement();

            builder.OpenElement(++seq, "circle");
            builder.AddAttribute(++seq, "cx", "21");
            builder.AddAttribute(++seq, "cy", "21");
            builder.AddAttribute(++seq, "r", "15.91549430918954");
            builder.AddAttribute(++seq, "fill", "transparent");
            builder.AddAttribute(++seq, "stroke", "#377bbc");
            builder.AddAttribute(++seq, "stroke-width", "5");
            builder.AddAttribute(++seq, "stroke-dasharray", "40 60");
            builder.AddAttribute(++seq, "stroke-dashoffset", "65");
            builder.OpenElement(++seq, "title");
            builder.AddContent(++seq, "Partners");
            builder.CloseElement();
            builder.OpenElement(++seq, "desc");
            builder.AddContent(++seq, "40% (40 out of 100)");
            builder.CloseElement();
            builder.CloseElement();

            builder.OpenElement(++seq, "g");
            builder.AddAttribute(++seq, "class", "doughnut-text");
            builder.OpenElement(++seq, "text");
                builder.AddAttribute(++seq, "x", "50%");
                builder.AddAttribute(++seq, "y", "50%");
                builder.AddAttribute(++seq, "class", "doughnut-number");
                builder.AddContent(++seq, "100");
            builder.CloseElement();
            builder.OpenElement(++seq, "text");
            builder.AddAttribute(++seq, "x", "50%");
            builder.AddAttribute(++seq, "y", "50%");
            builder.AddAttribute(++seq, "class", "doughnut-label");
            builder.AddContent(++seq, "Sales");
            builder.CloseElement();
            builder.CloseElement();

            builder.CloseElement();
            builder.CloseElement();

            builder.OpenElement(++seq, "figcaption");
            builder.AddAttribute(++seq, "class", "doughnut-key");
            builder.OpenElement(++seq, "ul");
            builder.AddAttribute(++seq, "class", "doughnut-key-list");
            builder.AddAttribute(++seq, "aria-hidden", "true");
            builder.AddAttribute(++seq, "style", "list-style-type: none;");

            builder.OpenElement(++seq, "li");
            builder.OpenElement(++seq, "span");
            builder.AddAttribute(++seq, "class", "round-dot dot-red");
            builder.CloseElement();
            builder.AddContent(++seq, "App Store (40)");
            builder.CloseElement();

            builder.OpenElement(++seq, "li");
            builder.OpenElement(++seq, "span");
            builder.AddAttribute(++seq, "class", "round-dot dot-green");
            builder.CloseElement();
            builder.AddContent(++seq, "Website (20)");
            builder.CloseElement();

            builder.OpenElement(++seq, "li");
            builder.OpenElement(++seq, "span");
            builder.AddAttribute(++seq, "class", "round-dot dot-blue");
            builder.CloseElement();
            builder.AddContent(++seq, "Partners (40)");
            builder.CloseElement();

            builder.CloseElement();
            builder.CloseElement();

            builder.CloseElement();
            */

        }
    }
}
