﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GUIResource
{
    public partial class StringResource
    {
        /// <summary>
        /// 字符枚举
        /// </summary>
        public enum TextType
        {
            Main_Menu_Mangt,
            Main_Menu_Mangt_AddConnection,
            Main_Menu_Mangt_Disconnect,
            Main_Menu_Mangt_Status,
            Main_Menu_Mangt_Refresh,
            Main_Menu_Mangt_Collapse,
            Main_Menu_Mangt_Expansion,
            Main_Menu_Mangt_Exit,
            Main_Menu_DataView,
            Main_Menu_DataView_Previous,
            Main_Menu_DataView_Next,
            Main_Menu_DataView_First,
            Main_Menu_DataView_Last,
            Main_Menu_DataView_Query,
            Main_Menu_DataView_Aggregation,
            Main_Menu_DataView_ConvertSql,
            Main_Menu_DataView_DataFilter,
            Main_Menu_DataView_Collapse,
            Main_Menu_DataView_Expansion,
            Main_Menu_Operation,
            Main_Menu_Operation_Server,
            Main_Menu_Operation_Server_NewDB,
            Main_Menu_Operation_Server_AddUserToAdmin,
            Main_Menu_Operation_Server_DelFromAdmin,
            Main_Menu_Operation_Server_CloseServer,
            Main_Menu_Operation_Server_Properties,
            Main_Menu_Operation_Database,
            Main_Menu_Operation_Database_DelDB,
            Main_Menu_Operation_Database_AddDC,
            Main_Menu_Operation_Database_AddUser,
            Main_Menu_Operation_Database_DelUser,
            Main_Menu_Operation_Database_EvalJs,
            Main_Menu_Operation_DataCollection,
            Main_Menu_Operation_DataCollection_DelDC,
            Main_Menu_Operation_DataCollection_Index,
            Main_Menu_Operation_DataCollection_DelSelect,
            Main_Menu_Operation_DataCollection_ReIndex,
            Main_Menu_Operation_DataCollection_Rename,

            Main_Menu_Operation_DataDocument,
            Main_Menu_Operation_DataDocument_AddElement,
            Main_Menu_Operation_DataDocument_DropElement,
            Main_Menu_Operation_DataDocument_ModifyElement,

            Main_Menu_Operation_FileSystem,
            Main_Menu_Operation_FileSystem_Upload,
            Main_Menu_Operation_FileSystem_Download,
            Main_Menu_Operation_FileSystem_OpenFile,
            Main_Menu_Operation_FileSystem_DelFile,
            Main_Menu_Operation_FileSystem_InitGFS,
            Main_Menu_Operation_BackupAndRestore,
            Main_Menu_Operation_BackupAndRestore_Restore,
            Main_Menu_Operation_BackupAndRestore_BackupDB,
            Main_Menu_Operation_BackupAndRestore_BackupDC,
            Main_Menu_Operation_BackupAndRestore_Import,
            Main_Menu_Operation_BackupAndRestore_Export,
            Main_Menu_Tool,
            Main_Menu_Tool_DOS,
            Main_Menu_Tool_Access,
            Main_Menu_Tool_Setting,
            Main_Menu_Distributed,
            Main_Menu_Distributed_ReplicaSet,
            Main_Menu_Distributed_ShardingConfig,
            Main_Menu_Help,
            Main_Menu_Help_About,
            Main_Menu_Help_Thanks,
            Main_Tab_Tree,
            Main_Tab_Table,
            Main_Tab_Text,
            Main_StatusBar_Text_Ready,

            AddConnection_Title,
            AddConnection_Name,
            AddConnection_Name_Description,
            AddConnection_Address,
            AddConnection_Address_Description,
            AddConnection_Port_Description,
            AddConnection_UserName_Description,
            AddConnection_Password_Description,
            AddConnection_DBName,
            AddConnection_DBName_Description,
            AddConnection_MainReplsetName,
            AddConnection_MainReplsetName_Description,
            AddConnection_Priority,
            AddConnection_TimeOut,
            AddConnection_MasterSlave,
            AddConnection_SafeMode,
            AddConnection_ShardingSvrType,
            AddConnection_ServerType_Data,
            AddConnection_ServerType_Configuration,
            AddConnection_ServerType_Route,
            AddConnection_ServerType_Arbitration,

            AddConnection_Region_ReplaceSet,
            AddConnection_Region_ReplaceSetName,
            AddConnection_Region_ReplaceSetName_Description,
            AddConnection_Region_ReplaceSetList,
            AddConnection_Region_ReplaceSetInit,
            AddConnection_Attention_Description,
            AddConnection_Attention2_Description,

            CollectionIndex_Title,
            CollectionIndex_Tab_Current,
            CollectionIndex_Tab_Current_Del,
            CollectionIndex_Tab_Manager,
            
            CollectionIndex_TabMangt_IndexName,
            CollectionIndex_TabMangt_IndexName_Description,

            Connect_Title,
            Connect_Action_Del,
            Connect_Action_Cancel,

            ConvertSql_Title,
            
            Distinct_Action_LoadQuery,
            Distinct_SelectField,

            DosCommand_Tab_Deploy,
            DosCommand_Tab_Deploy_Authentication,
            DosCommand_Tab_Deploy_MasterAddress,
            DosCommand_Tab_Deploy_Port,
            DosCommand_Tab_Deploy_MasterDB,
            DosCommand_Tab_Deploy_SlaveDB,
            DosCommand_Tab_Deploy_SlaveSource,
            DosCommand_Tab_Deploy_DBPath,
            DosCommand_Tab_Deploy_LogPath,
            DosCommand_Tab_Deploy_Log,
            DosCommand_Tab_Deploy_AppendMode,
            DosCommand_Tab_Backup,
            DosCommand_Tab_Backup_Server,
            DosCommand_Tab_Backup_Port,
            DosCommand_Tab_Backup_DBName,
            DosCommand_Tab_Backup_DCName,
            DosCommand_Tab_Backup_Path,
            DosCommand_Tab_ExIn,
            DosCommand_Tab_ExIn_Server,
            DosCommand_Tab_ExIn_Port,
            DosCommand_Tab_ExIn_DBName,
            DosCommand_Tab_ExIn_DCName,
            DosCommand_Tab_ExIn_ColumnList,
            DosCommand_Tab_ExIn_Workfile,
            DosCommand_Tab_ExIn_Import,
            DosCommand_Tab_ExIn_Export,
            DosCommand_Tab_ExIn_Operation,
            DosCommand_Run,
            DosCommand_Browse,
            DosCommand_Clean,
            DosCommand_LogLevel,

            EvalJS_Title,
            EvalJS_Method,
            EvalJS_Run,
            EvalJS_Parameter,

            Group_Tab_Reduce,
            Group_Tab_Finalize,
            Group_Tab_Group,
            Group_Tab_Group_Notes,
            Group_Tab_InitColumn,
            Group_Tab_InitColumn_Note,
            Group_Tab_Result,
            Group_LoadQuery,

            //Option
            Option_Title,
            Option_BinPath,
            Option_Language,
            Option_RecordPerPage,
            Option_RefreshInterval,

            //MapReduce
            MapReduce_MapFunction,
            MapReduce_ReduceFunction,
            MapReduce_Result,
            MapReduce_Run,

            Query_Title,
            Query_Filter,
            Query_Filter_AddCondition,
            Query_FieldInfo,
            Query_Action_Load,

            Replset_Title,
            Replset_AddServer,
            Replset_RemoveServer,
            Replset_Remove,

            ServiceStatus_Title,
            ServiceStatus_ServerInfo,
            ServiceStatus_DataBaseInfo,
            ServiceStatus_CollectionInfo,
            ServiceStatus_ClusterInfo,

            ShardingConfig_Title,
            ShardingConfig_AddSharding,
            ShardingConfig_ReplsetName,
            ShardingConfig_EnableSharding,
            ShardingConfig_DBName,
            ShardingConfig_CollectionName,
            ShardingConfig_FieldName,
            ShardingConfig_Action_DBSharding,
            ShardingConfig_Action_CollectionSharding,

            //Controller
            ctlIndexCreate_Index,
            ctlIndexCreate_Description,
            ctlFieldInfo_Show,

            //GFS
            GFS_filename,
            GFS_length,
            GFS_chunkSize,
            GFS_uploadDate,
            GFS_md5,

            //DataBase_Status
            DataBase_Status_DataBaseName,
            DataBase_Status_CollectionCount,
            DataBase_Status_DataSize,
            DataBase_Status_FileSize,
            DataBase_Status_IndexCount,
            DataBase_Status_IndexSize,
            DataBase_Status_ObjectCount,
            DataBase_Status_StorageSize,

            //Collection_Status
            Collection_Status_CollectionName,
            Collection_Status_ObjectCount,
            Collection_Status_DataSize,
            Collection_Status_LastExtentSize,
            Collection_Status_StorageSize,
            Collection_Status_TotalIndexSize,
            Collection_Status_AverageObjectSize,
            Collection_Status_PaddingFactor,

            //Index
            Index_Asce,
            Index_Desc,
            Index_NoSort,

            Index_Background,
            Index_RepeatDel,
            Index_Sparse,
            Index_Unify,
            Index_Name,
            Index_Keys,
            Index_Version,
            Index_NameSpace,
                    //异常
            Exception_NotConnected,
            Exception_AuthenticationException,

            Selected_Server,
            Selected_DataBase,
            Selected_Collection,
            Selected_Data,
            Selected_Indexes,
            Selected_Index,
            Selected_GFS,
            Selected_UserList,
            //公共
            Common_Username,
            Common_Password,
            Common_ReadOnly,
            Common_OK,
            Common_Cancel,
            Common_Refresh,
            Common_Yes,
            Common_No,
            Common_Detail,
            Common_Save,
            Common_Modify,
            Common_Add,
            Common_Server,
            Common_DataBase,
            Common_Collection,
            Common_HostName,
            Common_Port,
            Common_Browse,
            Common_Clear,

            //Create New DataBase
            Create_New_DataBase,
            Create_New_DataBase_Input,

            Drop_DataBase,
            Drop_DataBase_Confirm,

            Create_New_Collection,
            Create_New_Collection_Input,
            Rename_Collection,
            Rename_Collection_Input,
            Drop_Collection,
            Drop_Collection_Confirm,
            
            Drop_User,
            Drop_User_Confirm,
            
            Drop_Data,
            Drop_Data_Confirm
        }
    }
}
