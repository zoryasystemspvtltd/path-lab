using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathlabApi.Migrations
{
    /// <inheritdoc />
    public partial class minor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestResults",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestResults",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestResultDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestResultDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestRequestParameters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestRequestDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestRequestDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestReagentMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestReagentMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestReagentMapping",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestReagentMapping",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "TestMappingMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestMappingMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SpecimenMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SampleCollectorMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SampleCollectorMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "SampleCollectorFeeSetups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SampleCollectorFeeSetups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ReferralDoctorMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReferralDoctorMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ReferralDoctorFeeSetups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReferralDoctorFeeSetups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PatientDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PatientDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ParameterRangMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "EquipmentMasters",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EquipmentMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "EquipmentHeartBeats",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "EquipmentHeartBeats",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ControlResults",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ControlResults",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "ControlResultDetails",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ControlResultDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "AccountGroups",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AccountGroups",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestResults");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestResultDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestResultDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestRequestParameters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestRequestDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestRequestDetails");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestReagentMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestReagentMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestReagentMapping");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestReagentMapping");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "TestMappingMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestMappingMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SpecimenMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SampleCollectorMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SampleCollectorMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "SampleCollectorFeeSetups");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SampleCollectorFeeSetups");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ReferralDoctorMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReferralDoctorMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ReferralDoctorFeeSetups");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReferralDoctorFeeSetups");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PatientDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PatientDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ParameterRangMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "EquipmentMasters");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EquipmentMasters");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "EquipmentHeartBeats");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "EquipmentHeartBeats");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ControlResults");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ControlResults");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "ControlResultDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ControlResultDetails");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "AccountGroups");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AccountGroups");
        }
    }
}
