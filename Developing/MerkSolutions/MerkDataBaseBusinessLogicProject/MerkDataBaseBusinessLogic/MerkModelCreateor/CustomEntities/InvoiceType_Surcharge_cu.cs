﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public partial class InvoiceType_Surcharge_cu : DBCommon, IDBCommon
	{
		MerkFinanceEntities _context;
		private static List<InvoiceType_Surcharge_cu> _items;
		public static List<InvoiceType_Surcharge_cu> ItemsList = new List<InvoiceType_Surcharge_cu>();

		#region ColumnNames

		public static String InvoiceType_P_ID_ColumnaName
		{
			get { return "InvoiceType_P_ID"; }
		}

		public static String Surcharge_CU_ID_ColumnaName
		{
			get { return "Surcharge_CU_ID"; }
		}

		public static String IsApplied_ColumnaName
		{
			get { return "IsApplied"; }
		}

		public static String Description_ColumnaName
		{
			get { return "Description"; }
		}

		#endregion

		public override bool LoadFromDB
		{
			get { return true; }
		}

		public override DBCommonEntitiesType TableType
		{
			get { return DBCommonEntitiesType.CustomUserEntities; }
		}

		public override bool LoadItemsList()
		{
			ItemsList.Clear();
			ItemsList = DBContext_External.InvoiceType_Surcharge_cu.Where(item => item.IsOnDuty).OrderBy(item => item.ID).ToList();
			return true;
		}

		#region Implementation of IDBCommon

		public override IList ReGenerateList()
		{
			LoadItemsList();

			return ItemsList;
		}

		public int TableIdentityID
		{
			get { return (int)DB_TableIdentity.InvoiceType_Surcharge_cu; }
		}

		List<string> IDBCommon.ChildrenItemsList
		{
			get { return null; }
		}

		public string EntityName
		{
			get { return "InvoiceType_Surcharge_cu"; }
		}

		public IDBCommon GetSpecificEntity(MerkFinanceEntities context, int id)
		{
			return context.InvoiceType_Surcharge_cu.FirstOrDefault(item => item.ID.Equals(id));
		}

		#endregion
	}
}