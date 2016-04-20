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

namespace MAL.Module.UDMRelational
{
    [DefaultClassOptions]
    
    public class DetailIncident : IXafEntityObject, IObjectSpaceLink, INotifyPropertyChanged
    {
        public DetailIncident()
        {
            // In the constructor, initialize collection properties, e.g.: 
            // this.AssociatedEntities = new List<AssociatedEntityObject>();
        }
        [Browsable(false)]  // Hide the entity identifier from UI.
        public Int32 ID { get; protected set; }
        public string IncidentIdentifier { get; set; }
        public DateTime ReportedDate { get; set; }
        public DateTime LastResolvedDate { get; set; }
        public string OwnerGroup { get; set; }
        public DateTime SubmitDate { get; set; }
        public string AssignedGroup { get; set; }
        public string IncidentSummary { get; set; }
        public string Company { get; set; }
        public string ResolutionCategorization1 { get; set; }
        public string ResolutionCategorization2 { get; set; }
        public string ResolutionCategorization3 { get; set; }
        public string Submitter { get; set; }
        public string OperationalCategorizationTier1 { get; set; }
        public string OperationalCategorizationTier2 { get; set; }
        public string OperationalCategorizationTier3 { get; set; }
        public string AssignedSupportCompany { get; set; }
        public string SupportedSource { get; set; }





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
    }
}
