﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    using MixERP.HRM;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Tasks/Attendance/Index.cshtml")]
    public partial class _Views_Tasks_Attendance_Index_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<MixERP.HRM.DTO.EmployeeView>>
    {
        public _Views_Tasks_Attendance_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Tasks\Attendance\Index.cshtml"
  
    ViewBag.Title = "Attendance";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<style>\r\n    th.mini {\r\n        width: 150px;\r\n    }\r\n</style>\r\n<div");

WriteLiteral(" class=\"ui attached padded attendance segment\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(" data-localize=\"UpdateAttendanceRecord\"");

WriteLiteral("></div>\r\n    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n\r\n    <div");

WriteLiteral(" class=\"ui form bpad16\"");

WriteLiteral(" style=\"width: 440px;\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"two fields\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ui field\"");

WriteLiteral(">\r\n                <label>For Date</label>\r\n                <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"DateInputText\"");

WriteLiteral(" class=\"date\"");

WriteLiteral(" />\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"ui field\"");

WriteLiteral(">\r\n                <label>&nbsp;</label>\r\n                <button");

WriteLiteral(" id=\"ShowButton\"");

WriteLiteral(" class=\"ui green button\"");

WriteLiteral(">Show</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <table");

WriteLiteral(" class=\"ui attached form attendance table\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr>\r\n                <th");

WriteLiteral(" class=\"mini\"");

WriteLiteral(" data-localize=\"EmployeeId\"");

WriteLiteral("></th>\r\n                <th");

WriteLiteral(" data-localize=\"EmployeeName\"");

WriteLiteral("></th>\r\n                <th");

WriteLiteral(" class=\"mini\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" data-localize=\"WasPresent\"");

WriteLiteral("></div>\r\n                    <div");

WriteLiteral(" class=\"ui was present checkbox\"");

WriteLiteral(" style=\"padding: 0.5em;\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" data-localize=\"Yes\"");

WriteLiteral("></label>\r\n                    </div>\r\n                </th>\r\n                <th" +
"");

WriteLiteral(" class=\"mini\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" data-localize=\"CheckInTime\"");

WriteLiteral("></label>\r\n                    <div");

WriteLiteral(" class=\"ui action fluid input\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"time\"");

WriteLiteral(" class=\"time\"");

WriteLiteral(" />\r\n                        <button");

WriteLiteral(" class=\"ui icon button\"");

WriteLiteral(" data-localized-title=\"UpdateEmptyCheckIns\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"chevron right icon\"");

WriteLiteral("></i>\r\n                        </button>\r\n                    </div>\r\n           " +
"     </th>\r\n                <th");

WriteLiteral(" class=\"mini\"");

WriteLiteral(">\r\n                    <label");

WriteLiteral(" data-localize=\"CheckOutTime\"");

WriteLiteral("></label>\r\n                    <div");

WriteLiteral(" class=\"ui action fluid input\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" type=\"time\"");

WriteLiteral(" class=\"time\"");

WriteLiteral(" />\r\n                        <button");

WriteLiteral(" class=\"ui icon button\"");

WriteLiteral(" data-localized-title=\"UpdateEmptyCheckOuts\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"chevron right icon\"");

WriteLiteral("></i>\r\n                        </button>\r\n                    </div>\r\n           " +
"     </th>\r\n                <th");

WriteLiteral(" class=\"mini\"");

WriteLiteral(" data-localize=\"OvertimeHours\"");

WriteLiteral("></th>\r\n                <th");

WriteLiteral(" data-localize=\"AbsenteismReason\"");

WriteLiteral("></th>\r\n                <th");

WriteLiteral(" class=\"mini\"");

WriteLiteral(" data-localize=\"Update\"");

WriteLiteral("></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");

            
            #line 66 "..\..\Views\Tasks\Attendance\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Tasks\Attendance\Index.cshtml"
             foreach (var employee in Model)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteLiteral(" data-employee-id=\"");

            
            #line 68 "..\..\Views\Tasks\Attendance\Index.cshtml"
                                 Write(employee.EmployeeId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-attendance-id=\"\"");

WriteLiteral(">\r\n                    <td>");

            
            #line 69 "..\..\Views\Tasks\Attendance\Index.cshtml"
                   Write(employee.EmployeeId);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>");

            
            #line 70 "..\..\Views\Tasks\Attendance\Index.cshtml"
                   Write(employee.FirstName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 70 "..\..\Views\Tasks\Attendance\Index.cshtml"
                                       Write(employee.MiddleName);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 70 "..\..\Views\Tasks\Attendance\Index.cshtml"
                                                            Write(employee.LastName);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    <td>\r\n                        <div");

WriteLiteral(" class=\"ui was present checkbox\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(">\r\n                            <label>Yes</label>\r\n                        </div>" +
"\r\n                    </td>\r\n                    <td>\r\n                        <" +
"input");

WriteLiteral(" type=\"time\"");

WriteLiteral(" class=\"time\"");

WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                       " +
" <input");

WriteLiteral(" type=\"time\"");

WriteLiteral(" class=\"time\"");

WriteLiteral(" />\r\n                    </td>\r\n                    <td>\r\n                       " +
" <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"integer\"");

WriteLiteral(" />\r\n                    </td>\r\n                    <td><input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" /></td>\r\n                    <td><button");

WriteLiteral(" class=\"ui button\"");

WriteLiteral(">Update</button></td>\r\n                </tr>\r\n");

            
            #line 89 "..\..\Views\Tasks\Attendance\Index.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" onclick=\"updateAll()\"");

WriteLiteral(" class=\"ui teal button\"");

WriteLiteral(">Update All</button>\r\n    </div>\r\n\r\n</div>\r\n\r\n<script>\r\n    loadUI();\r\n    $(\".at" +
"tendance.segment\").fadeIn(1000);\r\n    $(\".ui.checkbox\").checkbox();\r\n\r\n    $(\"#S" +
"howButton\").off(\"click\").on(\"click\", function () {\r\n        function request(dat" +
"e) {\r\n            const url = \"/api/forms/hrm/attendances/get-where/-1/\";\r\n\r\n   " +
"         const filters = [];\r\n            filters.push(window.getAjaxColumnFilte" +
"r(\"WHERE\", \"AttendanceDate\", \"System.DateTime\", window.FilterConditions.IsEqualT" +
"o, date));\r\n            const data = JSON.stringify(filters);\r\n\r\n            ret" +
"urn window.getAjaxRequest(url, \"POST\", data);\r\n        };\r\n\r\n        const date " +
"= window.parseLocalizedDate($(\"#DateInputText\").val());\r\n\r\n        const ajax = " +
"request(date);\r\n\r\n        ajax.success(function (attendance) {\r\n            aler" +
"t(JSON.stringify(attendance));\r\n            //const a = window.Enumerable.From(a" +
"ttendance)\r\n            //    .Where(function (x) { return x.EmployeeId === empl" +
"oyee.EmployeeId }).FirstOrDefault() || new Object();\r\n\r\n            //a.CheckInT" +
"ime = (a.CheckInTime || \"\").toString().toTime();\r\n            //a.CheckOutTime =" +
" (a.CheckOutTime || \"\").toString().toTime();\r\n            //employees[i].Attenda" +
"nce = a;\r\n        });\r\n    });\r\n\r\n    function updateAll() {\r\n        function r" +
"equest(attendnaces) {\r\n            const url = \"/api/forms/hrm/attendance/bulk-i" +
"mport\";\r\n            const data = JSON.stringify(attendnaces);\r\n\r\n            re" +
"turn window.getAjaxRequest(url, \"POST\", data);\r\n        };\r\n\r\n        function g" +
"etModel() {\r\n            function getAttendance(row) {\r\n                const at" +
"tendanceDate = window.parseLocalizedDate($(\"#DateInputText\").val());\r\n          " +
"      const attendanceId = (row.attr(\"data-attendance-id\") || null);\r\n          " +
"      const employeeId = row.attr(\"data-employee-id\");\r\n                const is" +
"Present = row.find(\"input:checkbox\").is(\":checked\");\r\n                const chec" +
"kInTime = window.getTime(row.find(\"input.check-in\"));\r\n                const che" +
"ckOutTime = window.getTime(row.find(\"input.check-in\"));\r\n                const o" +
"verTimeHours = window.parseFloat2(row.find(\"input.overtime-hours\").val()) || 0;\r" +
"\n                const reason = row.find(\"input.reason\").val();\r\n\r\n             " +
"   return new\r\n                {\r\n                    AttendanceId: attendanceId" +
",\r\n                    OfficeId: window.metaView.OfficeId,\r\n                    " +
"EmployeeId: employeeId,\r\n                    AttendanceDate: attendanceDate,\r\n  " +
"                  WasPresent: isPresent,\r\n                    CheckInTime: isPre" +
"sent ? checkInTime : null,\r\n                    CheckOutTime: isPresent ? checkO" +
"utTime : null,\r\n                    OvertimeHours: overTimeHours,\r\n             " +
"       WasAbsent: !isPresent,\r\n                    ReasonForAbsenteeism: !isPres" +
"ent ? reason : null,\r\n                    AuditUserId: window.userId,\r\n         " +
"           AuditTs: new Date()\r\n                };\r\n            };\r\n\r\n          " +
"  const candidates = $(\"table.attendance tbody tr\");\r\n            const model = " +
"[];\r\n\r\n\r\n\r\n            $.each(candidates, function () {\r\n                const r" +
"ow = $(this);\r\n\r\n                const attendance = getAttendance(row);\r\n       " +
"         model.push(attendance);\r\n            });\r\n\r\n\r\n            return model;" +
"\r\n        };\r\n\r\n        const cards = $(\".attendance.card\");\r\n        const mode" +
"l = getModel();\r\n        const ajax = request(model);\r\n\r\n        ajax.success(fu" +
"nction () {\r\n            window.location = window.location.pathname;\r\n        })" +
";\r\n\r\n    };\r\n\r\n</script>");

        }
    }
}
#pragma warning restore 1591
