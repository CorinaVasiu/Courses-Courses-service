// DO NOT MODIFY THIS FILE; automatically generated by MMS
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Linq.Expressions;
using System.Linq;
using Microarea.Tbf.Model;
using Microarea.Tbf.Model.API;
using Microarea.Tbf.Model.Database;
using Microarea.Tbf.Model.Interfaces;
using Microarea.Tbf.Model.Interfaces.Database;
using Microarea.Tbf.Model.Interfaces.API;
using System.Threading.Tasks;
using Microarea.Generic.DataObj;

namespace Courses.Courses.Model
{
	
	/// <summary>
	/// Teachers table
	/// </summary>
	public partial class MMS_TeachersObj  : MasterEntity
	{
		public MMS_TeachersObj()
		{
		}

		/// <summary>
		/// Teacher field primary key segment
		/// This property is a primary Key 	
		/// DefaultValue: ""
		/// </summary>
		[TbPrimaryKey(0)]

		public string Teacher { get =>  f_Teacher.TypedDBValue;  set { f_Teacher.TypedDBValue = value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataStr f_Teacher { get ; private set; } = new DataStr();



		/// <summary>
		/// Description field
		/// 	
		/// DefaultValue: ""
		/// </summary>

		public string? Description { get =>  f_Description.TypedDBValue;  set { f_Description.TypedDBValue = value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataStr f_Description { get ; private set; } = new DataStr();



		/// <summary>
		/// Disabled field
		/// 	
		/// DefaultValue: false
		/// </summary>

		public bool? Disabled { get =>  f_Disabled.TypedDBValue;  set { f_Disabled.TypedDBValue = value.Value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataBool f_Disabled { get ; private set; } = new DataBool();




	}	

	[Table("MMS_Teachers")]
    [TbEntityTypeConfiguration(typeof(MMS_TeachersConfiguration))]
	public partial class MMS_Teachers : MMS_TeachersObj
	{
		public MMS_Teachers()
			:base()
		{
		}
	}

	public sealed class MMS_TeachersConfiguration : MMS_TeachersConfiguration<MMS_Teachers>
	{
		public MMS_TeachersConfiguration(DbType dbType, string subscription) 
			: base(dbType, subscription)
		{
		}

		public override void Configure(EntityTypeBuilder<MMS_Teachers> entity)
		{
			base.Configure(entity);
		}
	}

	public class MMS_TeachersConfiguration<TEntity> : AbstractEntityTypeConfiguration<TEntity> where TEntity : MMS_TeachersObj
    {
        public MMS_TeachersConfiguration(DbType dbType, string subscription)
            :base(dbType, subscription)
        {
        }

        public override void Configure(EntityTypeBuilder<TEntity> entity)
        { 
		
		#if NET6_0 || NET8_0 || NETCOREAPP3_1 || NETSTANDARD2_1
			entity.HasKey(e => e.Teacher).HasName("PK_MMS_Teachers").IsClustered(false);
		#else
			entity.HasKey(e => e.Teacher).HasName("PK_MMS_Teachers").ForSqlServerIsClustered(false);
		#endif

           
			#region Columns

			if(Database.IsSqlServer())
			{	
					entity.Property(e => e.Teacher).HasMaxLength(10).IsRequired().HasDefaultValueSql("('')")  ;
					entity.Property(e => e.Description).HasMaxLength(64).HasDefaultValueSql("('')")  ;
					entity.Property(e => e.Disabled).HasConversion(new BoolToTwoValuesConverter<char>('0', '1')).HasColumnType("nchar(1)")  ;
			
					entity.Property(e => e.TbCreated).IsRequired().HasColumnType("datetime").HasDefaultValueSql("getutcdate()");
					entity.Property(e => e.TbModified).IsRequired().HasColumnType("datetime").HasDefaultValueSql("getutcdate()");
					entity.Property(e => e.TbCreatedId).IsRequired().HasDefaultValueSql("0");
					entity.Property(e => e.TbModifiedId).IsRequired().HasDefaultValueSql("0");
					entity.Property(e => e.TbGuid).IsRequired().HasDefaultValueSql("NEWID()");
			}

			if(Database.IsNpgsql())
			{	
					entity.Property(e => e.Teacher).HasMaxLength(10).IsRequired().HasDefaultValueSql("('')")  ;
					entity.Property(e => e.Description).HasMaxLength(64).HasDefaultValueSql("('')")  ;
					entity.Property(e => e.Disabled).HasConversion(new BoolToTwoValuesConverter<char>('0', '1')).HasColumnType("char(1)")  ;
			
					entity.Property(e => e.TbCreated).IsRequired().HasColumnType("TIMESTAMP").HasDefaultValueSql("CURRENT_TIMESTAMP") ; 
					entity.Property(e => e.TbModified).IsRequired().HasColumnType("TIMESTAMP").HasDefaultValueSql("CURRENT_TIMESTAMP") ;
					entity.Property(e => e.TbCreatedId).IsRequired().HasDefaultValueSql("0");
					entity.Property(e => e.TbModifiedId).IsRequired().HasDefaultValueSql("0");
					entity.Property(e => e.TbGuid).IsRequired().HasDefaultValueSql("uuid_generate_v1()");
			}

			#endregion

			#region FK
			#endregion

			//AbstractEntityTypeConfiguration Method per AddOnField
			CheckConfiguration(entity);
		}
	}

	/// <summary>
	/// This Aggregate is used to read record based on PrimaryKey of table MMS_Teachers
	/// </summary>
	public class MMS_TeachersAggregate<TContext> : BaseTbAggregate<TContext, MMS_Teachers>
                                                                            where TContext : TbDbContext
    {
        public MMS_TeachersAggregate(TContext context, ITbDiagnostic diagnostic) 
            : base(context, diagnostic)
        {
        }

		private IQueryable<MMS_Teachers> Query(string teacher)
			=> EntityDbSet.Where(x => x.Teacher == teacher);

		#region SyncMethods 
		/// <summary>
		/// Return MMS_Teachers based on primary key parameters or default of TResult if not found 
		/// </summary>
		/// <remarks>be careful on default of TResult of non reference types.</remarks>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="teacher">Teacher field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>TResult based on projection function 'selector' or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public TResult GetMMS_Teachers<TResult>(string teacher,
		                                       Expression<Func<MMS_Teachers, TResult>> selector, TResult @default = default)		
			=> Result(Query(teacher).Select(selector), @default);

		/// <summary>
		/// Return ITbResult of MMS_Teachers based on primary key parameters
		/// </summary>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="teacher">Teacher field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>ITbResult based on projection function 'selector'</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public ITbResult<TResult> GetMMS_TeachersTbResult<TResult>(string teacher,
		                                                          Expression<Func<MMS_Teachers, TResult>> selector, TResult @default = default)
			=> TbResult(Query(teacher).Select(selector), @default);

		/// <summary>
		/// Return MMS_Teachers based on primary key parameters default of MMS_Teachers if not found
		/// </summary>
        /// <remarks>Prefered to use GetMMS_Teachers with selector parameter</remarks>
		
		/// <param name="teacher">Teacher field primary key segment</param>
		
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>An istance of MMS_Teachers or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        [Obsolete("Prefered to use GetMMS_Teachers with selector parameter")]
        public MMS_Teachers GetMMS_Teachers(string teacher,
												   MMS_Teachers @default = default)
			=> Result(Query(teacher), @default);
		#endregion


		#region AsyncMethods
		/// <summary>
		/// Return MMS_Teachers based on primary key parameters or default of TResult if not found with Async method
		/// </summary>
		/// <remarks>be careful on default of TResult of non reference types.</remarks>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="teacher">Teacher field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>TResult based on projection function 'selector' or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public Task<TResult> GetMMS_TeachersAsync<TResult>(string teacher,
		                                       Expression<Func<MMS_Teachers, TResult>> selector, TResult @default = default)		
			=> ResultAsync(Query(teacher).Select(selector), @default);

		/// <summary>
		/// Return ITbResult of MMS_Teachers based on primary key parameters with Async method
		/// </summary>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="teacher">Teacher field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>ITbResult based on projection function 'selector'</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public Task<ITbResult<TResult>> GetMMS_TeachersTbResultAsync<TResult>(string teacher,
		                                                          Expression<Func<MMS_Teachers, TResult>> selector, TResult @default = default)
			=> TbResultAsync(Query(teacher).Select(selector), @default);

		/// <summary>
		/// Return MMS_Teachers based on primary key parameters default of MMS_Teachers if not found with Async method
		/// </summary>
        /// <remarks>Prefered to use GetMMS_Teachers with selector parameter</remarks>
		
		/// <param name="teacher">Teacher field primary key segment</param>
		
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>An istance of MMS_Teachers or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        [Obsolete("Prefered to use GetMMS_Teachers with selector parameter")]
        public Task<MMS_Teachers> GetMMS_TeachersAsync(string teacher,
												   MMS_Teachers @default = default)
			=> ResultAsync(Query(teacher), @default);

		#endregion 
		
    }

}