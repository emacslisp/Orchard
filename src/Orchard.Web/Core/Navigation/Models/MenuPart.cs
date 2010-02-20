﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Orchard.ContentManagement;
using Orchard.Core.Navigation.Records;

namespace Orchard.Core.Navigation.Models {
    public class MenuPart : ContentPart<MenuPartRecord> {
        [HiddenInput(DisplayValue = false)]
        public int Id { get { return ContentItem.Id; } }

        public bool OnMainMenu {
            get { return Record.OnMainMenu; }
            set { Record.OnMainMenu = value; }
        }

        [Required]
        public string MenuText {
            get { return Record.MenuText; }
            set { Record.MenuText = value; }
        }

        public string MenuPosition {
            get { return Record.MenuPosition; }
            set { Record.MenuPosition = value; }
        }
    }
}