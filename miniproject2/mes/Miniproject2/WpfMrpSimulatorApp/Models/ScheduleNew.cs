using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMrpSimulatorApp.Models
{
    public partial class ScheduleNew
    {
        /// <summary>
        /// 공정계획 순번(자동증가)
        /// </summary>
        public int SchIdx { get; set; }

        /// <summary>
        /// 공장코드
        /// </summary>
        public string PlantCode { get; set; } = null!;

        // 데이터 그리드에 표현하려면 새로운 속성이 필요
        public string PlantName {  get; set; }

        /// <summary>
        /// 공정계획일
        /// </summary>
        public DateOnly SchDate { get; set; }

        /// <summary>
        /// 로드타임(초)
        /// 
        /// </summary>
        public int LoadTime { get; set; }

        public TimeOnly? SchStartTime { get; set; }

        public TimeOnly? SchEndTime { get; set; }

        /// <summary>
        /// 생산 설비 ID
        /// 
        /// </summary>
        public string? SchFacilityId { get; set; }

        public string? SchFacilityName { get; set; }

        public int? SchAmount { get; set; }

        public DateTime? RegDt { get; set; }

        /// <summary>
        /// 수정일
        /// </summary>
        public DateTime? ModDt { get; set; }

        public virtual ICollection<Process> Processes { get; set; } = new List<Process>();
    }
}
