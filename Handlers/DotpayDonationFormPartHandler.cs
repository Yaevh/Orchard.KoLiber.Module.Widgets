﻿using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.Localization;
using KoLiber.Module.Widgets.Models;
using Orchard.Environment.Extensions;

// This code was generated by Orchardizer

namespace KoLiber.Module.Widgets.Handlers {
    [OrchardFeature("KoLiber.Widgets.Dotpay")]
    public class DotpayDonationFormPartHandler : ContentHandler {
        public DotpayDonationFormPartHandler(IRepository<DotpayDonationFormPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));

            T = NullLocalizer.Instance;
        }

        public Localizer T { get; set; }
    }
}