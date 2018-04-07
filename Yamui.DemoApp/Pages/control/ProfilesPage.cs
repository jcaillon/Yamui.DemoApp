﻿#region header
// ========================================================================
// Copyright (c) 2017 - Julien Caillon (julien.caillon@gmail.com)
// This file (ProfilesPage.cs) is part of 3P.
// 
// 3P is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// 3P is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with 3P. If not, see <http://www.gnu.org/licenses/>.
// ========================================================================
#endregion

using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Yamui.Framework.Controls;
using Yamui.Framework.Controls.YamuiList;

namespace Yamui.DemoApp.Pages.control {

    internal partial class ProfilesPage : YamuiPage {

        #region fields

        #endregion

        #region constructor
        public ProfilesPage() {
            InitializeComponent();

            // scroll list
            var de = new List<ListItem>();
            for (int i = 0; i < 100; i++) {
                de.Add(new ListItem { DisplayText = "new" + i });
            }
            for (int i = 101; i < 1000; i++) {
                de.Add(new ListItem { DisplayText = "new" + i, IsDisabled = true });
            }
            for (int i = 1001; i < 100000; i++) {
                de.Add(new ListItem { DisplayText = "new" + i });
            }
            yamuiScrollList1.SetItems(de);
            

            // filtered list
            YamuiFilteredList1.SetItems(new List<ListItem> {
                new FilteredListItem { DisplayText = "CODAPP"},
                new FilteredListItem { DisplayText = "NOMOBJ"},
                new FilteredListItem { DisplayText = "CODORG"},
                new FilteredListItem { DisplayText = "PROFIL"},
                new FilteredListItem { DisplayText = "CODSOUFUCK"},
                new FilteredListItem { DisplayText = "CODORGA"},
                new FilteredListItem { DisplayText = "SRVEDIN"},
                new FilteredListItem { DisplayText = "NOMIMPR"},
                new FilteredListItem { DisplayText = "CHRONHA"},
                new FilteredListItem { DisplayText = "FUCK0"},
            });

            YamuiFilteredList1.EnterPressed += (list, e) => {
                //UserCommunication.Notify(list.SelectedItemIndex + " = " + (list.SelectedItem ?? new FilteredListItem { DisplayText = "null" }).DisplayText);
            };
            YamuiFilteredList1.TabPressed += (list, e) => {
                YamuiFilteredList1.ListPadding = new Padding(5, 10, 15, 25);
                list.SelectedItemIndex = 1115;
            };
            YamuiFilteredList1.RowClicked += (list, args) => {
                //UserCommunication.Notify(list.SelectedItemIndex + " " + args.Button + " " + args.Clicks + " " + args.Location);
            };

            flFilter1.TextChanged += YamuiFilteredList1.OnTextChangedEvent;
            flFilter1.KeyDown += (sender, args) => args.Handled = YamuiFilteredList1.PerformKeyDown(new KeyEventArgs(args.KeyCode));


            // autocompletion list
            //yamuiFilteredTypeList1.MoreTypesImage = ImageResources.More;

            flFilter1.TextChanged += yamuiFilteredTypeList1.OnTextChangedEvent;
            flFilter1.KeyDown += (sender, args) => args.Handled = yamuiFilteredTypeList1.PerformKeyDown(new KeyEventArgs(args.KeyCode));
            

            // tREE
            //yamuiFilteredTypeTreeList1.MoreTypesImage = ImageResources.More;
            yamuiFilteredTypeTreeList1.SetItems(new List<ListItem> {
                new TreeItem {
                    DisplayText = "the one",
                },
                new TreeItem {
                    DisplayText = "and second root",
                }
            });

            flFilter1.TextChanged += yamuiFilteredTypeTreeList1.OnTextChangedEvent;
            flFilter1.KeyDown += (sender, args) => args.Handled = yamuiFilteredTypeTreeList1.PerformKeyDown(new KeyEventArgs(args.KeyCode));
            flFilter1.Multiline = false;

            // -------------------------------------------------------------
            // ------------ BUTTONS ----------------------------------------
            // -------------------------------------------------------------

            btPlus.ButtonPressed += (sender, args) => {
                YamuiFilteredList1.Height += 10;
                yamuiScrollList1.Height += 10;
                yamuiFilteredTypeList1.Height += 10;
            };
            btMinus.ButtonPressed += (sender, args) => {
                YamuiFilteredList1.Height -= 10;
                yamuiScrollList1.Height -= 10;
                yamuiFilteredTypeList1.Height -= 10;
            };

            yamuiButton1.ButtonPressed += (sender, args) => {
                yamuiFilteredTypeList1.SetItems(de.Select(item => new FuckItem {
                    DisplayText = item.DisplayText,
                    //Type = item.Type,
                    //SubString = item.SubString,
                    //Flag = item.Flag
                }).Cast<ListItem>().ToList());
            };

            yamuiButton2.Text = @"switch tree mode";
            yamuiButton2.ButtonPressed += (sender, args) => {
                yamuiFilteredTypeTreeList1.SearchMode = yamuiFilteredTypeTreeList1.SearchMode == YamuiFilteredTypeTreeList.SearchModeOption.SearchSortWithNoParent ? YamuiFilteredTypeTreeList.SearchModeOption.FilterOnlyAndIncludeParent : YamuiFilteredTypeTreeList.SearchModeOption.SearchSortWithNoParent;
            };

            yamuiButton3.Text = @"modify root tree";
            yamuiButton3.ButtonPressed += (sender, args) => {
                yamuiFilteredTypeTreeList1.SetItems(new List<ListItem> {
                new TreeItem {
                    DisplayText = "NEW TEST",
                },
                new TreeItem {
                    DisplayText = "ALLO ild",
                }
            });
            };

            yamuiButton4.ButtonPressed += (sender, args) => {
                YamuiFilteredList1.SetItems(new List<ListItem> {
                    new FilteredListItem { DisplayText = "fuck1", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck2", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck3", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck4", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck5", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck6", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck7", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck8", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck9", IsDisabled = true},
                    new FilteredListItem { DisplayText = "fuck10", IsDisabled = true},
                });
            };

        }

        #endregion

    }

    internal class TreeItem : FilteredTypeTreeListItem {

        public override int ItemType {
            get { return Level; }
        }

        //public override Image ItemTypeImage {
        //    get {
        //        return (Image)ImageResources.ResourceManager.GetObject(ItemType == 0 ? "Block" : "Abbreviation");
        //    }
        //}
        //
        //public override Image ItemImage {
        //    get { return (Image)ImageResources.ResourceManager.GetObject(Level == 0 ? "Block" : "Abbreviation"); }
        //}

        public override bool IsRowHighlighted {
            get { return false; }
        }

        public override string SubText {
            get { return "Lvl " + Level; }
        }

        //public override List<Image> TagImages {
        //    get {
        //        return new List<Image> {
        //            (Image)ImageResources.ResourceManager.GetObject("Private"),
        //            (Image)ImageResources.ResourceManager.GetObject("New"),
        //        };
        //    }
        //}

        /// <summary>
        /// to override, does this item have children?
        /// </summary>
        public override bool CanExpand {
            get {
                return Level <= 3;
            }
        }

        /// <summary>
        /// to override, that should return the list of the children for this item (if any) or null
        /// </summary>
        public override List<FilteredTypeTreeListItem> Children {
            get { 
                return new List<FilteredTypeTreeListItem> {
                    new TreeItem {
                        DisplayText = "child 1",
                    },
                    new TreeItem {
                        DisplayText = "child 2",
                    },
                    new TreeItem {
                        DisplayText = "child 3",
                    }
                }; 
            }
        }

    }

    internal class FuckItem : FilteredTypeListItem {
        public string SubString;

        //public override Image ItemTypeImage {
        //    get {
        //        Image tryImg = (Image)ImageResources.ResourceManager.GetObject(((CompletionType)ItemType).ToString());
        //        return tryImg ?? ImageResources.Error;
        //    }
        //}

        public override Image ItemImage {
            get { return null; }
        }

        public override bool IsRowHighlighted {
            get { return false; }
        }

        public override string SubText {
            get { return SubString; }
        }

        //public override List<Image> TagImages {
        //    get {
        //        var outList = new List<Image>();
        //        foreach (var name in Enum.GetNames(typeof(ParseFlag))) {
        //            ParseFlag flag = (ParseFlag)Enum.Parse(typeof(ParseFlag), name);
        //            if (flag == 0 || !Flag.HasFlag(flag)) continue;
        //
        //            Image tryImg = (Image)ImageResources.ResourceManager.GetObject(name);
        //            if (tryImg != null) {
        //                outList.Add(tryImg);
        //            }
        //        }
        //        return outList;
        //    }
        //}
    }
}
