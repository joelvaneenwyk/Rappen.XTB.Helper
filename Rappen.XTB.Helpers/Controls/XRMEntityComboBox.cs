﻿using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XTB.Helpers.ControlItems;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Rappen.XTB.Helpers.Controls
{
    public partial class XRMEntityComboBox : ComboBox
    {
        #region Private properties

        private bool showFriendlyNames = true;
        private bool showFriendlyIncludingLogicalNames = false;
        private bool sorted = true;
        private IEnumerable<EntityMetadata> entities;
        private bool addnulloption;

        #endregion Private properties

        #region Public Constructors

        public XRMEntityComboBox()
        {
            InitializeComponent();
        }

        #endregion Public Constructors

        #region Public Properties

        [Category("Rappen XRM")]
        [Description("Indicates the source of data (collection of EntityMetadata) for the XRMEntityComboBox control.")]
        [Browsable(false)]
        public new object DataSource
        {
            get
            {
                if (entities != null)
                {
                    return entities;
                }
                return base.DataSource;
            }
            set
            {
                if (entities == null && value == null)
                {
                    return;
                }
                if (value is IEnumerable<EntityMetadata> newentities)
                {
                    entities = newentities;
                }
                else
                {
                    entities = null;
                }
                Refresh();
            }
        }

        [Category("Rappen XRM")]
        [DefaultValue(true)]
        [Description("True to show friendly names, False to show logical names and guid etc.")]
        public bool ShowFriendlyNames
        {
            get { return showFriendlyNames; }
            set
            {
                if (value != showFriendlyNames)
                {
                    showFriendlyNames = value;
                    Refresh();
                }
            }
        }

        [Category("Rappen XRM")]
        [DefaultValue(false)]
        [Description("True to also show logicalname after friendly names.")]
        public bool ShowFriendlyIncludingLogicalName
        {
            get { return showFriendlyIncludingLogicalNames; }
            set
            {
                if (value != showFriendlyIncludingLogicalNames)
                {
                    showFriendlyIncludingLogicalNames = value;
                    Refresh();
                }
            }
        }

        [Category("Rappen XRM")]
        [DefaultValue(true)]
        [Description("Defines if the entities should be sorted alphabetically, based on selected layout")]
        public new bool Sorted
        {
            get { return sorted; }
            set
            {
                base.Sorted = false;
                if (value != sorted)
                {
                    sorted = value;
                    Refresh();
                }
            }
        }

        [Category("Rappen XRM")]
        [DefaultValue(false)]
        [Description("Defines if a blank (null) option should be added at the top of the list of tables.")]
        public bool AddNullOption
        {
            get { return addnulloption; }
            set
            {
                if (value != addnulloption)
                {
                    addnulloption = value;
                    Refresh();
                }
            }
        }

        [Browsable(false)]
        public EntityMetadata SelectedEntity => SelectedItem is EntityMetadataItem item ? item.Metadata : null;

        #endregion Public Properties

        #region Public Methods

        public override void Refresh()
        {
            if (DesignMode)
            {
                return;
            }
            var selected = SelectedEntity?.LogicalName;
            var ds = entities?.Select(e => new EntityMetadataItem(e, showFriendlyNames, showFriendlyIncludingLogicalNames)).ToArray();
            if (sorted && ds?.Length > 0)
            {
                ds = ds.OrderBy(e => e.ToString()).ToArray();
            }
            if (ds != null && addnulloption)
            {
                ds = ds.Prepend(EntityMetadataItem.Empty).ToArray();
            }
            base.DataSource = ds;
            base.Refresh();
            SetSelected(selected);
        }

        public void SetSelected(string entitylogicalname)
        {
            if (!string.IsNullOrEmpty(entitylogicalname) &&
                base.DataSource is IEnumerable<EntityMetadataItem> ds &&
                ds?.FirstOrDefault(e => e.Metadata != null && e.Metadata.LogicalName.Equals(entitylogicalname)) is EntityMetadataItem newselected)
            {
                SelectedItem = newselected;
            }
            else
            {
                SelectedItem = null;
                SelectedIndex = -1;
            }
        }

        #endregion Public Methods
    }
}