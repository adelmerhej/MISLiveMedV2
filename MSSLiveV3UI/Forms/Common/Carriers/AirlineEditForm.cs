using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MISLiveMed.DataLayers.Common.Forms;
using MISLiveMed.DataLayers.Users;
using MISLiveMed.Models.Models.Common.Airlines;
using MISLiveMed.Models.Models.Users;
using MISLiveMed.UI.Utilities;

namespace MISLiveMed.UI.Forms.Common.Carriers
{
	public partial class AirlineEditForm : XtraForm
	{
		private const string _formName = "AirlineEdit";
		private int _formId;

		private AirlineModel _airLineModel = new AirlineModel();

		/// <summary>
		/// User Permission Role
		/// </summary>
		private IList<UserPermissionModel> _userPermission = new List<UserPermissionModel>();
		private readonly UserPermissionRepository _userPermissionRepository = new UserPermissionRepository();
		private readonly FormRepository _formRepository = new FormRepository();
		private readonly LogInfoRepository _logInfoRepository = new LogInfoRepository();

		//init permission variables
		private bool _canEdit;
		private bool _isAdmin;
		private bool _isProtected;

		public EventHandler SendUpdatedAirline;

		public AirlineEditForm(AirlineModel model)
		{
			InitializeComponent();
			try
			{
				_airLineModel = model;

				InitializeBindings();
				WireUpBindings();
				ApplyDefaults();
				ApplyPermissions();
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InitializeBindings()
		{
			try
			{
				//
				_formId = _formRepository.SelectFormByName(_formName);
				_userPermission = _userPermissionRepository.SelectUserPermissionById(CurrentUser.UserId, _formId);
				if (_userPermission != null && _userPermission.Count > 0)
				{
					var isProtected = _userPermission.SingleOrDefault(x => x.ControlName == "IsProtected")?.Value;
					if (isProtected != null) _isProtected = (bool)isProtected;
				}
				//

			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void WireUpBindings()
		{
			bsAirline.DataSource = _airLineModel;

		}

		private void ApplyDefaults()
		{

		}

		private void ApplyPermissions()
		{
			if (_userPermission == null) return;
			if (_userPermission.Count <= 0) return;

			var canEdit = _userPermission.SingleOrDefault(x => x.ControlName == "CanEdit")?.Value;
			if (canEdit != null) _canEdit = (bool)canEdit;

			var isAdmin = _userPermission.SingleOrDefault(x => x.ControlName == "IsAdmin")?.Value;
			if (isAdmin != null) _isAdmin = (bool)isAdmin;

			//txtNumber.ReadOnly = !_isAdmin || !_canEdit;
			//txtSerial.ReadOnly = !_isAdmin || !_canEdit;
			//txtAccountName.ReadOnly = !_isAdmin || !_canEdit;
			//cboAccountType.ReadOnly = !_isAdmin || !_canEdit;
			//cboCurrencies.ReadOnly = !_isAdmin || !_canEdit;
			//txtNotes.ReadOnly = !_isAdmin || !_canEdit;

			//chkProtected.Enabled = _isAdmin;
			//chkProtected.Visible = _isAdmin;
			//chkLocked.Enabled = _isAdmin || _canEdit;
			//chkActive.Enabled = _isAdmin || _canEdit;
			//btnSave.Enabled = _isAdmin || _canEdit;
		}


	}
}