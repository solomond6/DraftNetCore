using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverOnboarding.Utility
{
    public enum ApplicantRemarkStatus
    {
        Processing,
        Approved,
        Rejected
    }

    public enum ApplicationStatus
    {
        FreshOnboard = 0,
        VerificationFailed = 1,
        CompletedAssessment = 2,
        SubmittedForVerification = 3,
        SubmittedForVerificationWithGuarantor = 4,
        ScheduledForVerification = 5,
        ScheduledForVerificationWithGuarantor = 6,
        PendingVehicleAssignment = 7,
        VehicleAssigned = 8
    }

    public enum FingerprintVerificationResult
    {
        Matched,
        NotMatched,
        Inconclusive,
        InvalidImage
    }

    public enum ExaminationStatus
    {
        Pending,
        InProgress,
        Finished,
        TimeElapsed
    }

    public enum ExaminationQuestionSelectionMode
    {
        All,
        RandomPerQuestionNumber,
        Random,
        RandomPerCategory
    }


    public enum ImageType
    {
        Jpeg,
        Png
    }


    public enum YesNo
    {
        NotSet,
        Yes,
        No
    }

    public enum EducationalLevel
    {
        NotSet,
        Primary,
        Secondary,
        Tertiary

    }

    public enum VerificationStatus
    {
        NotSet,
        Fail,
        Pass
    }

    public enum VerificationResultSource
    {
        Driver,
        Guarantor,
        DriverDocuments,
        GuarantorDocument,
        DriverDispatchVerification,
        GuarantorDispatchVerification,
        GuarantorCreditReport,
        Test,
        PhysicalTest,
    }

    public enum VerificationCategory
    {
        All,
        Driver,
        Guarantor
    }

    public enum DocumentStatus
    {
        Mandatory,
        Optional
    }

    public enum DispatchScheduleMode
    {
        NotSet,
        DistributeEvenly,
        FillEachDispatch
    }


    public enum ScheduleFor
    {
        All,
        Driver,
        Guarantor
    }
}
