public UploadFile(string[] lineStrings, string userid)
 {
 MapUploadCcFile(lineStrings, userid);
 }
 public override int Id => 0;
 [DataMember(Name = "UploadCCFileId")]
 public int UploadFileId { get; set; }
 [DataMember(Name = "LloydsbrokerId")]
 public int LloydsbrokerId { get; set; }
 [DataMember(Name = "PlacingBasis")]
 public string PlacingBasis { get; set; }
 [DataMember(Name = "AssuredName")]
 public string AssuredName { get; set; }
 [DataMember(Name = "Leader")] public string Leader { get; set; }
 [DataMember(Name = "LeaderShare")] public decimal? LeaderShare { get; set; }
 [DataMember(Name = "InceptionDate")] public DateTime InceptionDate { get; set; }
 [DataMember(Name = "ExpiryDate")] public DateTime ExpiryDate { get; set; }
 [DataMember(Name = "EclipsePolicyId")] public int? EclipsePolicyId { get; set; }
 [DataMember(Name = "PriorEclipsePolicyRef")]
 public string PriorEclipsePolicyRef { get; set; }
 [DataMember(Name = "EclipsePolicyRef")]
 public string EclipsePolicyRef { get; set; }
 [DataMember(Name = "GroupClass")]
 public string GroupClass { get; set; }
 [DataMember(Name = "CurrentYearUMR")]
 public string CurrentYearUMR { get; set; }
 [DataMember(Name = "PriorYearUMR")]
 public string PriorYearUMR { get; set; }
 [DataMember(Name = "YOA")]
 public int YOA { get; set; }
 [DataMember(Name = "PremiumAt100Percent")]
 public decimal PremiumAt100Percent { get; set; }
 [DataMember(Name = "PremiumAt100PercentCurrency")]
 public string PremiumAt100PercentCurrency { get; set; }
 [DataMember(Name = "Limit")]
 public decimal? Limit { get; set; }
 [DataMember(Name = "LimitCurrency")]
 public string LimitCurrency { get; set; }
 [DataMember(Name = "Excess")]
 public decimal? Excess { get; set; }
 [DataMember(Name = "ExcessCurrency")]
 public string ExcessCurrency { get; set; }
 [DataMember(Name = "LineSizePercent")]
 public decimal? LineSizePercent { get; set; }
 [DataMember(Name = "LineSizeAmount")]
 public decimal? LineSizeAmount { get; set; }
 [DataMember(Name = "JourneyIndicator")]
 public int JourneyIndicator { get; set; }
 [DataMember(Name = "SectionStatusId")]
 public int SectionStatusId { get; set; }
 [DataMember(Name = "BusinessTypeId")]
 public int BusinessTypeId { get; set; }
 [DataMember(Name = "IsDeleted")]
 public bool IsDeleted { get; set; }
 [DataMember(Name = "SanctionedTerritoriesAck")]
 public bool SanctionedTerritoriesAck { get; set; }
 [DataMember(Name = "TermsAccepted")]
 public bool TermsAccepted { get; set; }
 [DataMember(Name = "RiskCode")]
 public string RiskCode { get; set; }
 [DataMember(Name = "PriorYearGNWP2987Share")]
 public decimal? PriorYearGNWP2987Share { get; set; }
 [DataMember(Name = "PriorYearGNWP2987ShareCurrency")]
 public string PriorYearGNWP2987ShareCurrency { get; set; }
 [DataMember(Name = "PriorYearGGWP2987Share")]
 public decimal? PriorYearGGWP2987Share { get; set; }
 [DataMember(Name = "PriorYearGGWP2987ShareCurrency")]
 public string PriorYearGGWP2987ShareCurrency { get; set; }
 [DataMember(Name = "PriorYearLimit100Percent")]
 public decimal? PriorYearLimit100Percent { get; set; }
 [DataMember(Name = "PriorYearLimit100PercentCurrency")]
 public string PriorYearLimit100PercentCurrency { get; set; }
 [DataMember(Name = "LBS")]
 public bool LBS { get; set; }
 [DataMember(Name = "CeilingPercent")]
 public decimal? CeilingPercent { get; set; }
 [DataMember(Name = "FloorPercent")]
 public decimal? FloorPercent { get; set; }
 [DataMember(Name = "PricingDateTime")]
 public DateTime? PricingDateTime { get; set; }
 [DataMember(Name = "IsMostMaterial")]
 public bool IsMostMaterial { get; set; }
 [DataMember(Name = "PlacingBasisId")]
 public int PlacingBasisId { get; set; }
 [DataMember(Name = "PlacingBasisDesc")]
 public string PlacingBasisDesc { get; set; }
 [DataMember(Name = "PreAdjustedLineSizePercent")]
 public decimal? PreAdjustedLineSizePercent { get; set; }
 [DataMember(Name = "PreAdjustedLineSizeAmount")]
 public decimal? PreAdjustedLineSizeAmount { get; set; }
 [DataMember(Name = "Grading")]
 public int Grading { get; set; }
 [DataMember(Name = "FXRateMonth")]
 public string FXRateMonth { get; set; }
 [DataMember(Name = "KiClassOfBusiness")]
 public string KiClassOfBusiness { get; set; }
 [DataMember(Name = "AlgoClassOfBusiness")]
 public string AlgoClassOfBusiness { get; set; }
 [DataMember(Name = "CSVVersion")]
 public int CSVVersion { get; set; }
 [DataMember(Name = "LoadToSectionFailed")]
 public bool LoadToSectionFailed { get; set; }
 [DataMember(Name = "ImportStatusId")]
 public int ImportStatusId { get; set; } = 1;
 [DataMember(Name = "ImportStatusMessage")]
 public string ImportStatusMessage { get; set; }
 [DataMember(Name = "LoadToSectionFailedMessage")]
 public string LoadToSectionFailedMessage { get; set; }
 [DataMember(Name = "SectionId")]
 public int? SectionId { get; set; }
 [DataMember(Name = "SectionLineId")]
 public int? SectionLineId { get; set; }
 [DataMember(Name = "LoadedToSectionDateTime")] public DateTime? LoadedToSectionDateT
ime { get; set; }
 [DataMember(Name = "BritPolicyId")]
 public int? BritPolicyId { get; set; }
 [DataMember(Name = "SectionTypeId")]
 public int? SectionTypeId { get; set; }
 [DataMember(Name = "LineSizeCurrency")]
 public string LineSizeCurrency { get; set; }
 [DataMember(Name = "OrgType")]
 public string OrgType { get; set; }
 private void MapUploadCcFile(string[] lineStrings, string userid)
 {
 try
 {
 this.LloydsbrokerId = Convert.ToInt32(lineStrings[0]);
 this.PlacingBasis = lineStrings[1];
 this.PlacingBasisDesc = !string.IsNullOrWhiteSpace(lineStrings[2]) ? lineStr
ings[2] : string.Empty;
 this.PlacingBasisId = !string.IsNullOrWhiteSpace(lineStrings[3]) ? Convert.T
oInt32(lineStrings[3]) : 0;
 this.AssuredName = lineStrings[4].Trim('"');
 this.Leader = lineStrings[5];
 this.LeaderShare = !lineStrings[6].Trim().Equals("NULL", StringComparison.Or
dinalIgnoreCase) && !string.IsNullOrEmpty(lineStrings[6]) ? Convert.ToDecimal(lineStrings[6]
) : (decimal?)null;
 this.InceptionDate = DateTime.ParseExact(lineStrings[7], @"M/d/yyyy", System
.Globalization.CultureInfo.InvariantCulture);
 this.ExpiryDate = DateTime.ParseExact(lineStrings[8], @"M/d/yyyy", System.Gl
obalization.CultureInfo.InvariantCulture);
 this.PriorEclipsePolicyRef = lineStrings[9];
 this.GroupClass = lineStrings[10];
 this.KiClassOfBusiness = lineStrings[11];
 this.EclipsePolicyRef = lineStrings[12];
 this.EclipsePolicyId = !lineStrings[13].Trim().Equals("NULL", StringComparis
on.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[13]) ? Convert.ToInt32(lineS
trings[13]) : (int?)null;
 this.BritPolicyId = !lineStrings[14].Trim().Equals("NULL", StringComparison.
OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[14]) ? Convert.ToInt32(lineStr
ings[14]) : (int?)null;
 this.PriorYearUMR = lineStrings[15];
 this.CurrentYearUMR = !lineStrings[16].Trim().Equals("NULL", StringCompariso
n.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[16])? lineStrings[16]: null;
 this.YOA = Convert.ToInt32(lineStrings[17]);
 this.PremiumAt100Percent = Convert.ToDecimal(lineStrings[18]);
 this.PremiumAt100PercentCurrency = !lineStrings[19].Trim().Equals("NULL", St
ringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(lineStrings[19]) ? lineStrings[19
].Trim() : "USD";
 
 this.Limit = !lineStrings[20].Trim().Equals("NULL", StringComparison.Ordinal
IgnoreCase) ? Convert.ToDecimal(lineStrings[20]) : (decimal?)null;
 this.LimitCurrency = lineStrings[21].Trim();
 this.Excess = !lineStrings[22].Trim().Equals("NULL", StringComparison.Ordina
lIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[22])
 ? Convert.ToDecimal(lineStrings[22])
 : (decimal?)null;
 if (this.Excess != null)
 this.ExcessCurrency = !lineStrings[23].Trim().Equals("NULL", StringCompa
rison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(lineStrings[23]) ? lineStrings[23].Trim()
: "USD";
 this.OrgType = lineStrings[24];
 this.JourneyIndicator = Convert.ToInt32(lineStrings[25]);
 this.SectionStatusId = Convert.ToInt32(lineStrings[26]);
 this.SectionTypeId = lineStrings[27].Length > 0 ? Convert.ToInt32(lineString
s[27]) : (int?)null;
 this.BusinessTypeId = Convert.ToInt32(lineStrings[28]);
 this.IsDeleted = Convert.ToBoolean(Convert.ToInt32(lineStrings[29]));
 this.SanctionedTerritoriesAck = Convert.ToBoolean(Convert.ToInt32(lineString
s[30]));
 this.TermsAccepted = Convert.ToBoolean(Convert.ToInt32(lineStrings[31]));
 this.RiskCode = lineStrings[32];
 this.PriorYearGNWP2987Share = !lineStrings[33].Trim().Equals("NULL", StringC
omparison.OrdinalIgnoreCase) ? Convert.ToDecimal(lineStrings[33]) : (decimal?)null;
 this.PriorYearGNWP2987ShareCurrency = !lineStrings[34].Trim().Equals("NULL",
StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(lineStrings[34]) ? lineStrings
[34].Trim() : "USD";
 this.PriorYearGGWP2987Share = !lineStrings[35].Trim().Equals("NULL", StringC
omparison.OrdinalIgnoreCase) ? Convert.ToDecimal(lineStrings[35]) : (decimal?)null;
 this.PriorYearGGWP2987ShareCurrency = !lineStrings[36].Trim().Equals("NULL",
StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(lineStrings[36]) ? lineStrings
[36].Trim() : "USD";
 this.PriorYearLimit100Percent = !lineStrings[37].Trim().Equals("NULL", Strin
gComparison.OrdinalIgnoreCase) ? Convert.ToDecimal(lineStrings[37]) : (decimal?)null;
 this.PriorYearLimit100PercentCurrency = !lineStrings[38].Trim().Equals("NULL
", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrEmpty(lineStrings[38]) ? lineStrin
gs[38].Trim() : "USD";
 this.IsMostMaterial = !string.IsNullOrWhiteSpace(lineStrings[39]) && Convert
.ToBoolean(Convert.ToInt32(lineStrings[39]));
 this.LineSizePercent = !lineStrings[41].Trim().Equals("NULL", StringComparis
on.OrdinalIgnoreCase) ? Convert.ToDecimal(lineStrings[41].Trim('%')) : (decimal?)null;
 this.LineSizeAmount = !lineStrings[42].Trim().Equals("NULL", StringCompariso
n.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[42]) ? Convert.ToDecimal(line
Strings[42]) : (decimal?)null;
 this.LineSizeCurrency = this.LineSizeAmount.HasValue
 ? !lineStrings[43].Trim().Equals("NULL", StringComparison.OrdinalIgnoreC
ase) &&
 !string.IsNullOrEmpty(lineStrings[43])
 ? lineStrings[43].Trim()
 : "USD"
 : string.Empty;
 this.Grading = Convert.ToInt32(lineStrings[46]);
 this.PreAdjustedLineSizeAmount = this.LineSizeAmount;
 this.PreAdjustedLineSizePercent = this.LineSizePercent;
 this.FloorPercent = !lineStrings[47].Trim().Equals("NULL", StringComparison.
OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[47]) ? Convert.ToDecimal(lineSt
rings[47]) : (decimal?)null;
 this.CeilingPercent = !lineStrings[48].Trim().Equals("NULL", StringCompariso
n.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(lineStrings[48]) ? Convert.ToDecimal(line
Strings[48]) : (decimal?)null;
 this.FXRateMonth = lineStrings[49];
 this.PricingDateTime = !string.IsNullOrWhiteSpace(lineStrings[50]) ? Convert
.ToDateTime(lineStrings[50]) : (DateTime?)null;
 this.LBS = Convert.ToBoolean(Convert.ToInt32(lineStrings[51]));
 this.AlgoClassOfBusiness = lineStrings[52];
 this.CSVVersion = 1;
 this.CreatedBy = userid;
 this.CreatedDateTime = DateTime.UtcNow;
 this.LastUpdatedBy = userid;
 this.LastUpdatedDateTime = DateTime.UtcNow;
 this.LoadToSectionFailed = false;
 this.ImportStatusId = 1;
 this.ImportStatusMessage = string.Empty;
 }
 catch (Exception exception)
 {
 this.ImportStatusId = 2;
 this.ImportStatusMessage = exception.Message;
 }
 }
 }
}
2.2 Azure Function Http Trigger: Upload File 
[ProducesResponseType(typeof(UploadCcFileOp.Response), 200)]
 [ProducesResponseType(typeof(ErrorOp.Response), 400)]
 [ProducesResponseType(typeof(ErrorOp.Response), 401)]
 [ProducesResponseType(StatusCodes.Status403Forbidden)]
 [ApiExplorerSettings(GroupName = SwaggerApi.Groups.Internal)]
 [HttpPost("UploadFile")]
 public async Task<IActionResult> UploadFile(
 [Required(ErrorMessage = MissingUserIdErrorMessage)][MaxLength(255)]
 [FromHeader(Name = Headers.UserId)] string auditUserId,
 IFormFile file)
 {
 try
 {
 _logger.LogInformation("Started to save bulk upload data");
 try
 {
 if (file == null)
 return new BadRequestObjectResult(ErrorOp.Response.BadRequest("Provi
de Input File"));
 if (!file.ContentType.Equals("application/vnd.msexcel", StringComparison.InvariantCultureIgnoreCase) && (!file.ContentType.Equals("text/csv"
, StringComparison.InvariantCultureIgnoreCase)))
 return new BadRequestObjectResult(ErrorOp.Response.BadRequest("Provi
de csv Input File"));
 var result = await _service.SaveToUpload(file, auditUserId);
 if (result.ErrorResponse != null)
 {
 if (result.ErrorResponse.ErrorCode.Equals(404))
 return new NotFoundObjectResult(result);
 return new BadRequestObjectResult(result);
 }
 return new OkObjectResult(result);
 }
 catch (Exception exception)
 {
 _logger.LogError("An Error occurred while trying to fetch csv file in th
e RequestBody", exception.Message);
 return new BadRequestObjectResult("Provide Valid csv file.");
 }
 }
 catch (Exception exception)
 {
 _logger.LogError("Internal server error unable to upload spreadsheet to Uplo
adCCFile table", exception.Message);
 throw;
 }
 }
SaveToUpload Function:
public async Task<UploadCcFileOp.Response> SaveToUpload(IFormFile file, string userid)
 {
 var invalidRows = InvalidRows<UploadCCFile>(file)
 .Select(_ => new UploadCcFileOp.Response.DataColumn(_.Key, _.Value))
 .ToList();
 var mandatoryFlag = false;
 foreach (var row in invalidRows)
 {
 mandatoryFlag = Enum.IsDefined(typeof(UploadCcFileMandoryFields), row.Name);
 }
 if (mandatoryFlag)
 {
 return new UploadCcFileOp.Response()
 {
 ErrorResponse = ErrorResponse.BadRequest("LineSizePercent, LineSizeAmoun
t, LimitCurrency, Grading must not be Null or Empty"),
 IsSaved = false,
 Invalidrows = invalidRows
 };
 }
 foreach (var batchList in ReadLines(file, userid).Batch(100))
 {
 var sectionRepo = _repoFactory.Create<UploadCCFile>();
 List<UploadCCFile> invalidUploadFileValues = batchList.Where(x => x.ImportSt
atusId == 2).ToList();
 if (invalidUploadFileValues.Count > 0)
 {
 return new UploadCcFileOp.Response()
 { ErrorResponse = ErrorResponse.BadRequest("Invalid data in spreadsheet"
), IsSaved = false, InvalidValueCcFiles = invalidUploadFileValues.ToList() };
 }
 await sectionRepo.Add(batchList.ToArray());
 }
 return new UploadCcFileOp.Response { IsSaved = true, Invalidrows = invalidRows }
;
 }