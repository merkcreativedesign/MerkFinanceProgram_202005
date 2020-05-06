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
	public class CashBoxInOutTransaction_DataCollector<TEntity> : AbstractDataCollector<TEntity>, ICashBoxInOutTransactionViewer
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

			ID = ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).ID;

			if (ActiveDBItem == null)
				return false;

			//((CashBoxInOutTransaction) ActiveDBItem).DBCommonTransactionType = CommonTransactionType;


			//if (CashBoxTransactionType_P_ID != null)
			//	((CashBoxInOutTransaction)ActiveDBItem).CashBoxTransactionType_P_ID =
			//		Convert.ToInt32(CashBoxTransactionType_P_ID);

			//if (TransactionAmount != null)
			//	((CashBoxInOutTransaction) ActiveDBItem).TransactionAmount = Convert.ToDouble(TransactionAmount);

			//if (TranscationSerial != null)
			//	((CashBoxInOutTransaction) ActiveDBItem).TranscationSerial = TranscationSerial.ToString();

			//if (Description != null)
			//	((CashBoxInOutTransaction)ActiveDBItem).Description = Description.ToString();

			//((CashBoxInOutTransaction) ActiveDBItem).PaymentType_P_ID = (int) DB_PaymentType.CashPayment;
			//((CashBoxInOutTransaction) ActiveDBItem).IsCancelled = false;

			//if (UserID != null)
			//	((CashBoxInOutTransaction)ActiveDBItem).InsertedBy = Convert.ToInt32(UserID);

			//((CashBoxInOutTransaction)ActiveDBItem).IsOnDuty = true;
			//switch (((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).CommonTransactionType)
			//{
			//	case DB_CommonTransactionType.DeleteExisting:
			//		((CashBoxInOutTransaction)ActiveDBItem).IsOnDuty = false;
			//		break;
			//}

			//RelatedViewers = ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).RelatedViewers;

			return true;
		}

		public override object ID { get; set; }

		public override object ViewerID
		{
			get { return (int)ViewerName.CashBoxInOutTrasactionViewer; }
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
		public override string HeaderTitle
		{
			get { throw new System.NotImplementedException(); }
		}

		public override string GridXML
		{
			get { throw new System.NotImplementedException(); }
		}

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
			List<CashBoxInOutTransaction> list = CashBoxInOutTransaction.ItemsList.FindAll(item => item.IsOnDuty);
			return list.ToArray();
		}

		public override bool CreateNew()
		{
			if (ActiveDBItem == null)
			{
				ActiveDBItem = DBCommon.CreateNewDBEntity<CashBoxInOutTransaction>();

				((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).CommonTransactionType =
					DB_CommonTransactionType.SaveNew;
				return true;
			}
			return false;
		}

		public override bool ValidateBeforeSave(ref string message)
		{
			if (CashBoxTransactionType_P_ID == null)
			{
				MessageToView = "يجــب إختيــار نــوع المعـاملـــة الماليـــــة";
				return false;
			}

			if (TransactionAmount == null)
			{
				MessageToView = "يجــب كتابـــة قيمــــة المعـاملـــة الماليـــــة";
				return false;
			}

			return true;
		}

		public override bool SaveChanges(DB_CommonTransactionType commonTransactionType)
		{
			if (ActiveCollector.ActiveDBItem == null)
				return false;

			if (CashBoxInOutTransactionsList != null && CashBoxInOutTransactionsList.FindAll(item =>
				    Convert.ToInt32(item.AddedType).Equals(Convert.ToInt32(AddedType.NewelyAdded))).Count > 0)
			{
				foreach (CashBoxInOutTransaction cashBoxInOutTransaction in CashBoxInOutTransactionsList.FindAll(item =>
					Convert.ToInt32(item.AddedType).Equals(Convert.ToInt32(AddedType.NewelyAdded))))
				{
					cashBoxInOutTransaction.DBCommonTransactionType = DB_CommonTransactionType.SaveNew;
					cashBoxInOutTransaction.InsertedBy = Convert.ToInt32(UserID);
					cashBoxInOutTransaction.PaymentType_P_ID = (int) DB_PaymentType.CashPayment;
					cashBoxInOutTransaction.IsCancelled = false;

					if (UserID != null)
						cashBoxInOutTransaction.InsertedBy = Convert.ToInt32(UserID);

					cashBoxInOutTransaction.IsOnDuty = true;
					switch (((ICashBoxInOutTransactionViewer) ActiveCollector.ActiveViewer).CommonTransactionType)
					{
						case DB_CommonTransactionType.DeleteExisting:
							cashBoxInOutTransaction.IsOnDuty = false;
							break;
					}

					cashBoxInOutTransaction.SaveChanges();
				}
			}

			if (CashBoxInOutTransaction.ItemsList != null && CashBoxInOutTransaction.ItemsList.FindAll(item =>
				    Convert.ToInt32(item.DBCommonTransactionType)
					    .Equals(Convert.ToInt32(DB_CommonTransactionType.DeleteExisting))).Count > 0)
			{
				foreach (CashBoxInOutTransaction cashBoxInOutTransaction in CashBoxInOutTransaction.ItemsList.FindAll(
					item => Convert.ToInt32(item.DBCommonTransactionType)
						.Equals(Convert.ToInt32(DB_CommonTransactionType.DeleteExisting))))
				{
					cashBoxInOutTransaction.IsOnDuty = false;
					cashBoxInOutTransaction.SaveChanges();
				}
			}


			((CashBoxInOutTransaction)ActiveCollector.ActiveDBItem).LoadItemsList();

			return true;
		}

		public override void Edit(IDBCommon entity)
		{
			CashBoxTransactionType_P_ID = ((CashBoxInOutTransaction)ActiveDBItem).CashBoxTransactionType_P_ID;
			TransactionAmount = ((CashBoxInOutTransaction)ActiveDBItem).TransactionAmount;
			TranscationSerial = ((CashBoxInOutTransaction)ActiveDBItem).TranscationSerial;
			Description = ((CashBoxInOutTransaction)ActiveDBItem).Description;

			((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).ID = ((CashBoxInOutTransaction)ActiveDBItem).ID;
			ActiveCollector.ActiveDBItem.ID = ((CashBoxInOutTransaction)ActiveDBItem).ID;

			base.Edit(ActiveCollector.ActiveDBItem);
		}

		public override bool Delete(IDBCommon entity)
		{
			return ((CashBoxInOutTransaction)entity).RemoveItem();
		}

		#endregion

		#region Implementation of ICashBoxInOutTransactionViewer

		public object CashBoxTransactionType_P_ID
		{
			get { return ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).CashBoxTransactionType_P_ID; }
			set { ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).CashBoxTransactionType_P_ID = value; }
		}
		public object TransactionAmount
		{
			get { return ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).TransactionAmount; }
			set { ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).TransactionAmount = value; }
		}
		public object TranscationSerial
		{
			get { return ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).TranscationSerial; }
			set { ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).TranscationSerial = value; }
		}
		public object Description
		{
			get { return ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).Description; }
			set { ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).Description = value; }
		}

		public object TranscationDate
		{
			get { return ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).TranscationDate; }
			set { ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).TranscationDate = value; }
		}

		public List<CashBoxInOutTransaction> CashBoxInOutTransactionsList
		{
			get { return ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).CashBoxInOutTransactionsList; }
			set { ((ICashBoxInOutTransactionViewer)ActiveCollector.ActiveViewer).CashBoxInOutTransactionsList = value; }
		}

		#endregion
	}
}
