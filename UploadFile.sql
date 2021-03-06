CREATE TABLE [dbo].[UploadFile](
[UploadCCFileId] [int] IDENTITY(1,1) NOT NULL,
[LloydsbrokerId] [int] NOT NULL,
[PlacingBasis] [varchar] (3) NOT NULL,
[AssuredName] [varchar] (255) NOT NULL,
[Leader] [varchar] (255) NOT NULL,
[LeaderShare] [decimal](5, 2) NULL,
[InceptionDate] [date] NOT NULL,
[ExpiryDate] [date] NOT NULL,
[EclipsePolicyId] [int] NULL,
[PriorEclipsePolicyRef] [varchar] (20) NOT NULL,
[EclipsePolicyRef] [varchar] (20) NOT NULL,
[GroupClass] [varchar] (100) NOT NULL,
[CurrentYearUMR] [varchar] (17) NULL,
[PriorYearUMR] [varchar] (17) NOT NULL,
[YOA] [int] NOT NULL,
[PremiumAt100Percent] [decimal](18, 2) NOT NULL,
[PremiumAt100PercentCurrency] [varchar] (5) NOT NULL,
[Limit] [decimal] (18, 2) NULL,
[LimitCurrency] [varchar] (5) NULL,
[Excess] [decimal] (18, 2) NULL,
[ExcessCurrency] [varchar] (5) NULL,
[LineSizePercent] [decimal](5, 2) NULL,
[LineSizeAmount] [decimal](18, 2) NULL,
[LineSizeCurrency] [varchar] (5) NULL,
[JourneyIndicator] [int] NOT NULL,
[SectionStatusId] [int] NOT NULL,
[BusinessTypeId] [int] NOT NULL,
[IsDeleted] [bit] NOT NULL,
[SanctionedTerritoriesAck] [bit] NOT NULL,
[TermsAccepted] [bit] NOT NULL,
[RiskCode] [varchar] (100) NOT NULL,
[PriorYearGNWP2987Share] [decimal] (18, 2) NULL,
[PriorYearGNWP2987ShareCurrency] [varchar] (5) NULL,
[PriorYearGGWP2987Share] [decimal](18, 2) NULL,
[PriorYearGGWP2987ShareCurrency] [varchar] (5) NULL,
[PriorYearLimit100Percent] [decimal](18, 2) NULL,
[PriorYearLimit100PercentCurrency] [varchar] (5) NULL,
[LBS] [bit] NOT NULL,
[CeilingPercent] [decimal](5, 2) NULL,
[FloorPercent] [decimal](5, 2) NULL,
[Grading] [int] NOT NULL,
[FXRateMonth] [varchar] (6) NOT NULL,
[LoadToSectionFailed] [bit] NOT NULL,
[LoadToSectionFailedMessage] [varchar] (4096) NULL,
[LoadedToSectionDateTime] [datetime2] (7) NULL,
[SectionId] [int] NULL,
[SectionLineId] [int] NULL,
[CSVVersion] [int] NOT NULL,
BritPolicyId] [int] NULL,
[SectionTypeId] [int] NULL,
[PricingDateTime] [datetime2] (7) NULL,
[IsMostMaterial] [bit] NOT NULL,
[PlacingBasisID] [int] NOT NULL,
[PlacingBasisDesc] [varchar] (50) NOT NULL,
[PreAdjustedLineSizePercent] [decimal](5, 2) NULL,
[PreAdjustedLineSizeAmount] [decimal](18, 2) NULL,
[KiClassOfBusiness] [varchar](255) NULL,
[AlgoClassOfBusiness] [varchar](255) NULL,
[OrgType] [varchar](50) NULL,
[Underwriter] [varchar](255) NULL,
[AssistedChangeReasonId] [int] NULL,
[AssistedChangeReasonDesc] [nvarchar](max) NULL,
[PriorYearWrittenLineSizePercent] [decimal](5, 2) NULL,
[PriorYearWrittenLineSizeAmount] [decimal](18,2) NULL,
[PriorYearWrittenLineSizeCurrency] [varchar] (5) NULL,
[PriorYearSignedLineSizePercent] [decimal](5, 2) NULL,
[PriorYearSignedLineSizeAmount] [decimal](18,2) NULL,
[PriorYearSignedLineSizeCurrency] [varchar] (5) NULL,
[ExpiringSectionId] [int] NULL,
[ExpiringSectionLineId] [int] NULL,
[UploadType] [varchar](50) NULL,
[CreatedBy] [varchar] (255) NOT NULL,
[CreatedDateTime] [datetime2] (7) NOT NULL,
[LastUpdatedBy] [varchar] (255) NOT NULL,
[LastUpdatedDateTime] [datetime2] (7) NOT NULL,
[ImportStatusId] [int] NULL,
[ImportStatusMessage] [varchar] (100) NULL
CONSTRAINT [PK_UploadCC] PRIMARY KEY CLUSTERED ([UploadCCFileId] ASC);