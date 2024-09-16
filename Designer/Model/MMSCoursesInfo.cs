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
	/// Slave table
	/// </summary>
	public partial class MMS_CoursesInfoObj  : BaseEntity
	{
		public MMS_CoursesInfoObj()
		{
		}

		/// <summary>
		/// CourseId field primary key segment
		/// This property is a primary Key 	
		/// DefaultValue: 0
		/// </summary>
		[TbPrimaryKey(0)]

		public Int32 CourseId { get =>  f_CourseId.TypedDBValue;  set { f_CourseId.TypedDBValue = value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataLng f_CourseId { get ; private set; } = new DataLng();



		/// <summary>
		/// Days field
		/// 	
		/// DefaultValue: 0
		/// </summary>

		public Int16? Days { get =>  f_Days.TypedDBValue;  set { f_Days.TypedDBValue = value.Value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataInt f_Days { get ; private set; } = new DataInt();



		/// <summary>
		/// Teacher field
		/// 	
		/// DefaultValue: ""
		/// </summary>

		public string? Teacher { get =>  f_Teacher.TypedDBValue;  set { f_Teacher.TypedDBValue = value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataStr f_Teacher { get ; private set; } = new DataStr();



		/// <summary>
		/// Notes field
		/// 	
		/// DefaultValue: ""
		/// </summary>

		public string? Notes { get =>  f_Notes.TypedDBValue;  set { f_Notes.TypedDBValue = value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataStr f_Notes { get ; private set; } = new DataStr();



		/// <summary>
		/// PriceADay field
		/// 	
		/// DefaultValue: 0.0
		/// </summary>

		public double? PriceADay { get =>  f_PriceADay.TypedDBValue;  set { f_PriceADay.TypedDBValue = value.Value; } }
		/// <summary>
		/// property exposed for value management and field entity
		/// </summary>
		[NotMapped]
		public DataMon f_PriceADay { get ; private set; } = new DataMon();




	}	

	[Table("MMS_CoursesInfo")]
    [TbEntityTypeConfiguration(typeof(MMS_CoursesInfoConfiguration))]
	public partial class MMS_CoursesInfo : MMS_CoursesInfoObj
	{
		public MMS_CoursesInfo()
			:base()
		{
		}
	}

	public sealed class MMS_CoursesInfoConfiguration : MMS_CoursesInfoConfiguration<MMS_CoursesInfo>
	{
		public MMS_CoursesInfoConfiguration(DbType dbType, string subscription) 
			: base(dbType, subscription)
		{
		}

		public override void Configure(EntityTypeBuilder<MMS_CoursesInfo> entity)
		{
			base.Configure(entity);
		}
	}

	public class MMS_CoursesInfoConfiguration<TEntity> : AbstractEntityTypeConfiguration<TEntity> where TEntity : MMS_CoursesInfoObj
    {
        public MMS_CoursesInfoConfiguration(DbType dbType, string subscription)
            :base(dbType, subscription)
        {
        }

        public override void Configure(EntityTypeBuilder<TEntity> entity)
        { 
		
		#if NET6_0 || NET8_0 || NETCOREAPP3_1 || NETSTANDARD2_1
			entity.HasKey(e => e.CourseId).HasName("PK_MMS_CoursesInfo").IsClustered(false);
		#else
			entity.HasKey(e => e.CourseId).HasName("PK_MMS_CoursesInfo").ForSqlServerIsClustered(false);
		#endif

           
			#region Columns

			if(Database.IsSqlServer())
			{	
					entity.Property(e => e.CourseId).HasDefaultValueSql("('0')").ValueGeneratedNever()  ;
					entity.Property(e => e.Days).HasDefaultValueSql("('0')")  ;
					entity.Property(e => e.Teacher).HasMaxLength(10).HasDefaultValueSql("('')")  ;
					entity.Property(e => e.Notes).HasColumnType("ntext").HasDefaultValueSql("('')")  ;
					entity.Property(e => e.PriceADay).HasDefaultValueSql("('0.0')")  ;
			
					entity.Property(e => e.TbCreated).IsRequired().HasColumnType("datetime").HasDefaultValueSql("getutcdate()");
					entity.Property(e => e.TbModified).IsRequired().HasColumnType("datetime").HasDefaultValueSql("getutcdate()");
					entity.Property(e => e.TbCreatedId).IsRequired().HasDefaultValueSql("0");
					entity.Property(e => e.TbModifiedId).IsRequired().HasDefaultValueSql("0");
			}

			if(Database.IsNpgsql())
			{	
					entity.Property(e => e.CourseId).HasColumnType("integer").HasDefaultValueSql("('0')").ValueGeneratedNever()  ;
					entity.Property(e => e.Days).HasColumnType("smallint").HasDefaultValueSql("('0')")  ;
					entity.Property(e => e.Teacher).HasMaxLength(10).HasDefaultValueSql("('')")  ;
					entity.Property(e => e.Notes).HasColumnType("Text").HasDefaultValueSql("('')")  ;
					entity.Property(e => e.PriceADay).HasDefaultValueSql("('0.0')")  ;
			
					entity.Property(e => e.TbCreated).IsRequired().HasColumnType("TIMESTAMP").HasDefaultValueSql("CURRENT_TIMESTAMP") ; 
					entity.Property(e => e.TbModified).IsRequired().HasColumnType("TIMESTAMP").HasDefaultValueSql("CURRENT_TIMESTAMP") ;
					entity.Property(e => e.TbCreatedId).IsRequired().HasDefaultValueSql("0");
					entity.Property(e => e.TbModifiedId).IsRequired().HasDefaultValueSql("0");
			}

			#endregion

			#region FK
			#endregion

			//AbstractEntityTypeConfiguration Method per AddOnField
			CheckConfiguration(entity);
		}
	}

	/// <summary>
	/// This Aggregate is used to read record based on PrimaryKey of table MMS_CoursesInfo
	/// </summary>
	public class MMS_CoursesInfoAggregate<TContext> : BaseTbAggregate<TContext, MMS_CoursesInfo>
                                                                            where TContext : TbDbContext
    {
        public MMS_CoursesInfoAggregate(TContext context, ITbDiagnostic diagnostic) 
            : base(context, diagnostic)
        {
        }

		private IQueryable<MMS_CoursesInfo> Query(Int32 courseId)
			=> EntityDbSet.Where(x => x.CourseId == courseId);

		#region SyncMethods 
		/// <summary>
		/// Return MMS_CoursesInfo based on primary key parameters or default of TResult if not found 
		/// </summary>
		/// <remarks>be careful on default of TResult of non reference types.</remarks>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="courseId">CourseId field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>TResult based on projection function 'selector' or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public TResult GetMMS_CoursesInfo<TResult>(Int32 courseId,
		                                       Expression<Func<MMS_CoursesInfo, TResult>> selector, TResult @default = default)		
			=> Result(Query(courseId).Select(selector), @default);

		/// <summary>
		/// Return ITbResult of MMS_CoursesInfo based on primary key parameters
		/// </summary>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="courseId">CourseId field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>ITbResult based on projection function 'selector'</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public ITbResult<TResult> GetMMS_CoursesInfoTbResult<TResult>(Int32 courseId,
		                                                          Expression<Func<MMS_CoursesInfo, TResult>> selector, TResult @default = default)
			=> TbResult(Query(courseId).Select(selector), @default);

		/// <summary>
		/// Return MMS_CoursesInfo based on primary key parameters default of MMS_CoursesInfo if not found
		/// </summary>
        /// <remarks>Prefered to use GetMMS_CoursesInfo with selector parameter</remarks>
		
		/// <param name="courseId">CourseId field primary key segment</param>
		
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>An istance of MMS_CoursesInfo or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        [Obsolete("Prefered to use GetMMS_CoursesInfo with selector parameter")]
        public MMS_CoursesInfo GetMMS_CoursesInfo(Int32 courseId,
												   MMS_CoursesInfo @default = default)
			=> Result(Query(courseId), @default);
		#endregion


		#region AsyncMethods
		/// <summary>
		/// Return MMS_CoursesInfo based on primary key parameters or default of TResult if not found with Async method
		/// </summary>
		/// <remarks>be careful on default of TResult of non reference types.</remarks>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="courseId">CourseId field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>TResult based on projection function 'selector' or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public Task<TResult> GetMMS_CoursesInfoAsync<TResult>(Int32 courseId,
		                                       Expression<Func<MMS_CoursesInfo, TResult>> selector, TResult @default = default)		
			=> ResultAsync(Query(courseId).Select(selector), @default);

		/// <summary>
		/// Return ITbResult of MMS_CoursesInfo based on primary key parameters with Async method
		/// </summary>
		/// <typeparam name="TResult">Generic TResult</typeparam>
		
		/// <param name="courseId">CourseId field primary key segment</param>
		
		/// <param name="selector">Project the founded element into a new form.</param>
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>ITbResult based on projection function 'selector'</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        public Task<ITbResult<TResult>> GetMMS_CoursesInfoTbResultAsync<TResult>(Int32 courseId,
		                                                          Expression<Func<MMS_CoursesInfo, TResult>> selector, TResult @default = default)
			=> TbResultAsync(Query(courseId).Select(selector), @default);

		/// <summary>
		/// Return MMS_CoursesInfo based on primary key parameters default of MMS_CoursesInfo if not found with Async method
		/// </summary>
        /// <remarks>Prefered to use GetMMS_CoursesInfo with selector parameter</remarks>
		
		/// <param name="courseId">CourseId field primary key segment</param>
		
		/// <param name="default">default value returned if no value is found</param>
		/// <returns>An istance of MMS_CoursesInfo or default if not found</returns>
        /// <exception cref="InvalidOperationException">Throw when result has more than one element.</exception>
        [Obsolete("Prefered to use GetMMS_CoursesInfo with selector parameter")]
        public Task<MMS_CoursesInfo> GetMMS_CoursesInfoAsync(Int32 courseId,
												   MMS_CoursesInfo @default = default)
			=> ResultAsync(Query(courseId), @default);

		#endregion 
		
    }

}