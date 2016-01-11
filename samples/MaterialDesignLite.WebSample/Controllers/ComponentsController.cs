﻿using MaterialDesignLite.TagHelpers.StyleValues;
using MaterialDesignLite.WebSample.ViewModels;
using Microsoft.AspNet.Mvc;

namespace MaterialDesignLite.WebSample.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Badges()
        {
            return View(new PageViewConfig
            {
                Header = new Header {
                    BgColor = MDLColors.Amber,
                    Title = "Badge",
                    SubTitle = "Small status descriptors for UI elements." },
            });
        }

        public IActionResult Buttons()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Pink,
                    Title = "Button",
                    SubTitle = "blblblblb"
                },
            });
        }

        public IActionResult Cards()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Orange,
                    Title = "Cards",
                    SubTitle = "Self-contained pieces of paper with data."
                },
                RightOnHeader = false
            });
        }
        public IActionResult Grid() {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Blue,
                    Title = "Grid",
                    SubTitle = "blblblblb"
                },
            });
        }

        public IActionResult Tabs()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.DeepPurple,
                    Title = "Tabs",
                    SubTitle = "The Material Design Lite (MDL) tab component is a user interface element that allows different content blocks to share the same screen space in a mutually exclusive manner"
                },
            });
        }
        public IActionResult Footer() { return View(); }
        public IActionResult Loading() { return View(); }
        public IActionResult Menus() { return View(); }
        public IActionResult Sliders() { return View(); }
        public IActionResult Toggles() { return View(); }
        public IActionResult Tables() { return View(); }
        public IActionResult TextFields()
        {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.DeepPurple,
                    Title = "TextFields",
                    SubTitle = "blblblblb"
                },
            });
        }
        public IActionResult Tooltips() {
            return View(new PageViewConfig
            {
                Header = new Header
                {
                    BgColor = MDLColors.Orange,
                    Title = "Tooltips",
                    SubTitle = "Useful information on hover."
                },
            });
        }
    }
}
