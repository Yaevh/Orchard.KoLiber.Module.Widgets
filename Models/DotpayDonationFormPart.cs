﻿using System.ComponentModel.DataAnnotations;
using Orchard.ContentManagement;
using Orchard.Environment.Extensions;

// This code was generated by Orchardizer

namespace KoLiber.Module.Widgets.Models {
    [OrchardFeature(Consts.DotpayFeatureID)]
    public class DotpayDonationFormPart : ContentPart<DotpayDonationFormPartRecord> {

        [Range(0, int.MaxValue, ErrorMessage = "Invalid Dotpay ID")]
        public int DotpayId {
            get { return Retrieve(x => Record.DotpayId); }
            set { Store(x => Record.DotpayId, value); }
        }

        [Range(0, double.PositiveInfinity, ErrorMessage = "Suggested donation amount should be positive")]
        public double? SuggestedAmount {
            get { return Retrieve(x => Record.SuggestedAmount); }
            set { Store(x => Record.SuggestedAmount, value); }
        }

        public string Purpose {
            get { return Retrieve(x => Record.Purpose); }
            set { Store(x => Record.Purpose, value); }
        }

        [Url]
        public string ReturnUrl {
            get { return Retrieve(x => Record.ReturnUrl); }
            set { Store(x => Record.ReturnUrl, value); }
        }

    }
}