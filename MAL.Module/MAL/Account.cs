using System;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;

namespace MAL.Module.BusinessObjects
{
    // Register this entity in the DbContext using the "public DbSet<Account> Accounts { get; set; }" syntax.
    [DefaultClassOptions]
   
    public class Account : IXafEntityObject, IObjectSpaceLink, INotifyPropertyChanged
    {
        public Account()
        { 
            this.Service = new List<Service>();
            this.Alias = new List<AccountAlias>();
            this.Tool = new List<Tool>();
        }
        [Browsable(false)]
        public string AccountID { get; protected set; }

        #region IXafEntityObject members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIXafEntityObjecttopic.aspx)
        void IXafEntityObject.OnCreated()
        {
            // Place the entity initialization code here.
            // You can initialize reference properties using Object Space methods; e.g.:
            // this.Address = objectSpace.CreateObject<Address>();
        }
        void IXafEntityObject.OnLoaded()
        {
            // Place the code that is executed each time the entity is loaded here.
        }
        void IXafEntityObject.OnSaving()
        {
            // Place the code that is executed each time the entity is saved here.
        }
        #endregion

        #region IObjectSpaceLink members (see https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppIObjectSpaceLinktopic.aspx)
        // Use the Object Space to access other entities from IXafEntityObject methods (see https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113707.aspx).
        private IObjectSpace objectSpace;
        IObjectSpace IObjectSpaceLink.ObjectSpace
        {
            get { return objectSpace; }
            set { objectSpace = value; }
        }
        #endregion

        #region INotifyPropertyChanged members (see http://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged(v=vs.110).aspx)
        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        public string AccountName { get; set; }
        public string ParentAccountId { get; set; }
        public string ParentAccountName { get; set; }
        public string MasterAccountId { get; set; }
        public string MasterAccountName { get; set; }
        public string Customer { get; set; }
        public string SnowDomainName { get; set; }
        public string CapCode { get; set; }
        public double AccountTcvPotential { get; set; }
        public double AccountTcvAwarded { get; set; }
        public DateTime ContractStartDate { get; set; }
        public DateTime ContractExpiryDate { get; set; }
        public string ContractType { get; set; }
        public double ContractTermInMonth { get; set; }
        public int CurrentContractYear { get; set; }
        public string ContractBaseOptions { get; set; }
        public string SfdcIdNumber { get; set; }
        public bool HasServiceLevelAgreements { get; set; }
        public bool HasContractualReportingRequirements { get; set; }
        public string AccountFinancialsParentFamily { get; set; }
        public string PaymentTerms { get; set; }
        public string SecurityRestrictions { get; set; }
        public string WorkScope { get; set; }
        public string AccountStatus { get; set; }
        public string Comments { get; set; }
        public string AccountIndustry { get; set; }
        public string AccountCountry { get; set; }
        public string AccountRegion { get; set; }
        public string PrimaryDeliveryRegion { get; set; }
        public string OedRegion { get; set; }
        public string LeadOffering { get; set; }
        public virtual IList<Service> Service { get; set; }
        public virtual IList<AccountAlias> Alias { get; set; }
        public virtual IList<Tool> Tool { get; set; }
    }
}
