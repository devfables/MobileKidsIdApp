﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csla;
using System.ComponentModel.DataAnnotations;

namespace MobileKidsIdApp.Models
{
    [Serializable]
    public class ChildDetails : BaseTypes.BusinessBase<ChildDetails>
    {
        public static readonly PropertyInfo<string> GivenNameProperty = RegisterProperty<string>(c => c.GivenName);
        [Display(Name = "Given/First Name")]
        [Required]
        public string GivenName
        {
            get { return GetProperty(GivenNameProperty); }
            set { SetProperty(GivenNameProperty, value); }
        }

        public static readonly PropertyInfo<string> NickNameProperty = RegisterProperty<string>(c => c.NickName);
        public string NickName
        {
            get { return GetProperty(NickNameProperty); }
            set { SetProperty(NickNameProperty, value); }
        }

        public static readonly PropertyInfo<string> AdditionalNameProperty = RegisterProperty<string>(c => c.AdditionalName);
        public string AdditionalName
        {
            get { return GetProperty(AdditionalNameProperty); }
            set { SetProperty(AdditionalNameProperty, value); }
        }

        public static readonly PropertyInfo<string> FamilyNameProperty = RegisterProperty<string>(c => c.FamilyName);
        [Required]
        public string FamilyName
        {
            get { return GetProperty(FamilyNameProperty); }
            set { SetProperty(FamilyNameProperty, value); }
        }

        public static readonly PropertyInfo<DateTime> BirthdayProperty = RegisterProperty<DateTime>(c => c.Birthday);
        public DateTime Birthday
        {
            get { return GetProperty(BirthdayProperty); }
            set { SetProperty(BirthdayProperty, value); }
        }

        public static readonly PropertyInfo<string> ContactIdProperty = RegisterProperty<string>(c => c.ContactId);
        public string ContactId
        {
            get { return GetProperty(ContactIdProperty); }
            set { SetProperty(ContactIdProperty, value); }
        }

        public static readonly PropertyInfo<string> ContactNameManualProperty = RegisterProperty<string>(c => c.ContactNameManual);
        public string ContactNameManual
        {
            get { return GetProperty(ContactNameManualProperty); }
            set { SetProperty(ContactNameManualProperty, value); }
        }

        public static readonly PropertyInfo<string> ContactPhoneManualProperty = RegisterProperty<string>(c => c.ContactPhoneManual);
        public string ContactPhoneManual
        {
            get { return GetProperty(NickNameProperty); }
            set { SetProperty(NickNameProperty, value); }
        }

        protected override void Child_Create()
        {
            using (BypassPropertyChecks)
            {
                Birthday = DateTime.Today;
            }
        }

        private void Child_Fetch(DataAccess.DataModels.ChildDetails details)
        {
            using (BypassPropertyChecks)
            {
                GivenName = details.GivenName;
                AdditionalName = details.AdditonalName;
                FamilyName = details.FamilyName;
                Birthday = details.Birthday;
                ContactId = details.ContactId;
            }
        }

        private void Child_Insert(DataAccess.DataModels.ChildDetails details)
        {
            Child_Update(details);
        }

        private void Child_Update(DataAccess.DataModels.ChildDetails details)
        {
            using (BypassPropertyChecks)
            {
                details.GivenName = GivenName;
                details.AdditonalName = AdditionalName;
                details.FamilyName = FamilyName;
                details.Birthday = Birthday;
                details.ContactId = ContactId;
            }
        }

        private void Child_DeleteSelf()
        {
            // do nothing - if we don't re-add this item it won't exist
        }
    }
}
