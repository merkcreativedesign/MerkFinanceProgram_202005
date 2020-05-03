﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MerkDataBaseBusinessLogicProject.EntitiesOperationsBusinessLogicLibrary;
using MerkDataBaseBusinessLogicProject.MerkDataBaseBusinessLogic.MerkModelCreateor.DBCommon;

namespace MerkDataBaseBusinessLogicProject
{
	public partial class Address_cu : DBCommon, IDBCommon
	{
		MerkFinanceEntities _context;
		private static List<Address_cu> _items;
		public static List<Address_cu> ItemsList = new List<Address_cu>();

		#region ColumnNames

		public static String Country_CU_ID_ColumnaName
		{
			get { return "Country_CU_ID"; }
		}

		public static String City_CU_ID_ColumnaName
		{
			get { return "City_CU_ID"; }
		}

		public static String Region_CU_ID_ColumnaName
		{
			get { return "Region_CU_ID"; }
		}

		public static String Territory_CU_ID_ColumnaName
		{
			get { return "Territory_CU_ID"; }
		}

		public static String BuildingNumber_ColumnaName
		{
			get { return "BuildingNumber"; }
		}

		public static String FloorNumber_ColumnaName
		{
			get { return "FloorNumber"; }
		}

		public static String ZipCode_ColumnaName
		{
			get { return "ZipCode"; }
		}

		public static String AddressLine1_ColumnaName
		{
			get { return "AddressLine1"; }
		}

		public static String AddressLine2_ColumnaName
		{
			get { return "AddressLine2"; }
		}

		#endregion

		public override IList ReGenerateList()
		{
			LoadItemsList();

			return ItemsList;
		}

		public int TableIdentityID
		{
			get { return (int) DB_TableIdentity.Address_cu; }
		}

		List<string> IDBCommon.ChildrenItemsList
		{
			get { return null; }
		}

		public string EntityName
		{
			get { return "Address_cu"; }
		}

		public IDBCommon GetSpecificEntity(MerkFinanceEntities context, int id)
		{
			return context.Address_cu.FirstOrDefault(item => item.ID.Equals(id));
		}

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
			ItemsList = DBContext_External.Address_cu.Where(item => item.IsOnDuty).OrderBy(item => item.ID).ToList();
			return true;
		}

	}
}