using System;
using System.Collections.Generic;
using ApplicationConfiguration;
using MerkDataBaseBusinessLogicProject;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;
using MVCBusinessLogicLibrary.MVCFactories;
using MVCBusinessLogicLibrary.Viewers;

namespace MVCBusinessLogicLibrary.MVCDataCollectors
{
	public class FinanceDailyTransaction_DataCollector<TEntity> : AbstractDataCollector<TEntity>, IFinanceDailyTransactionViewer
		where TEntity : DBCommon, IDBCommon, new()
	{
		#region Overrides of AbstractDataCollector<TEntity>

		public override AbstractDataCollector<TEntity> ActiveCollector { get; set; }
		public override AbstractDataCollector<TEntity> ParentActiveCollector { get; set; }
		public override bool Collect(AbstractDataCollector<TEntity> collector)
		{
			if (collector == null)
				return false;

			ActiveCollector = collector;

			ID = ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).ID;

			if (ActiveDBItem == null)
				return false;

			if (DailyTransactionType != null)
				((FinanceDailyTransaction) ActiveDBItem).DailyTransactionType_P_ID =
					Convert.ToInt32(DailyTransactionType);

			if (Amount != null)
				((FinanceDailyTransaction)ActiveDBItem).Amount = Convert.ToDouble(Amount);

			if (Date != null)
				((FinanceDailyTransaction)ActiveDBItem).Date = Convert.ToDateTime(Date);

			if (Description != null)
				((FinanceDailyTransaction)ActiveDBItem).Description = Description.ToString();

			((FinanceDailyTransaction)ActiveDBItem).IsOnDuty = true;
			switch (((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).CommonTransactionType)
			{
				case DB_CommonTransactionType.DeleteExisting:
					((FinanceDailyTransaction)ActiveDBItem).IsOnDuty = false;
					break;
			}

			RelatedViewers = ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).RelatedViewers;

			return true;
		}

		public override object ID { get; set; }

		public override object ViewerID
		{
			get { return (int)ViewerName.FinanceDailyTransaction_Viewer; }
		}

		public override object UserID
		{
			get
			{
				if (ApplicationStaticConfiguration.ActiveLoginUser != null)
					return ApplicationStaticConfiguration.ActiveLoginUser.Person_CU_ID;
				return null;
			}
		}

		public override object EditingDate
		{
			get { return DateTime.Now; }
		}
		public override object IsOnDUty { get; set; }
		public override DB_CommonTransactionType CommonTransactionType { get; set; }
		public override string HeaderTitle { get; }
		public override string GridXML { get; }
		public override List<IViewer> RelatedViewers { get; set; }

		public override void ClearControls()
		{
			throw new System.NotImplementedException();
		}

		public override void FillControls()
		{
			throw new System.NotImplementedException();
		}

		public override object[] CollectSearchCriteria()
		{
			List<FinanceDailyTransaction> list = FinanceDailyTransaction.ItemsList.FindAll(item => item.IsOnDuty);
			return list.ToArray();
		}

		public override bool CreateNew()
		{
			if (ActiveDBItem == null)
			{
				ActiveDBItem = DBCommon.CreateNewDBEntity<FinanceDailyTransaction>();

				((IFinanceDailyTransactionViewer) ActiveCollector.ActiveViewer).CommonTransactionType =
					DB_CommonTransactionType.SaveNew;
				return true;
			}
			return false;
		}

		public override bool SaveChanges(DB_CommonTransactionType commonTransactionType)
		{
			if (ActiveCollector.ActiveDBItem == null)
				return false;

			if (((FinanceDailyTransaction)ActiveCollector.ActiveDBItem).SaveChanges())
			{
				((FinanceDailyTransaction)ActiveCollector.ActiveDBItem).LoadItemsList();
				return true;
			}

			return false;
		}

		public override void Edit(IDBCommon entity)
		{
			DailyTransactionType = ((FinanceDailyTransaction)ActiveDBItem).DailyTransactionType_P_ID;
			Amount = ((FinanceDailyTransaction)ActiveDBItem).Amount;
			Date = ((FinanceDailyTransaction)ActiveDBItem).Date;
			Description = ((FinanceDailyTransaction)ActiveDBItem).Description;

			((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).ID = ((FinanceDailyTransaction)ActiveDBItem).ID;
			ActiveCollector.ActiveDBItem.ID = ((FinanceDailyTransaction)ActiveDBItem).ID;

			base.Edit(ActiveCollector.ActiveDBItem);
		}

		public override bool Delete(IDBCommon entity)
		{
			return ((FinanceDailyTransaction)entity).RemoveItem();
		}

		#endregion

		#region Implementation of IFinanceDailyTransactionViewer

		public object DailyTransactionType
		{
			get { return ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).DailyTransactionType; }
			set { ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).DailyTransactionType = value; }
		}

		public object Amount
		{
			get { return ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).Amount; }
			set { ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).Amount = value; }
		}

		public object Date
		{
			get { return ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).Date; }
			set { ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).Date = value; }
		}

		public object Description
		{
			get { return ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).Description; }
			set { ((IFinanceDailyTransactionViewer)ActiveCollector.ActiveViewer).Description = value; }
		}


		#endregion
	}
}
