using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Qualtrics.Digital;
using ExampleApp.Surveys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleApp.Droid
{
    public class SurveyDroid : ISurvey
    {
        Activity Context;
        public SurveyDroid(Activity context)
        {
            Context = context;
        }


        public void ShowQualtricsSurvey()
        {
            Qualtrics.Instance().Properties.SetString("RoomCreated", "RoomCreated");
            Qualtrics.Instance().EvaluateIntercept("SI_0MtTEfyqNYVa2O2", new CallBack(Context));
        }

        class CallBack : Java.Lang.Object, IQualtricsCallback
        {
            Activity Context;
            public CallBack(Activity context)
            {
                Context = context;
            }


            public void Run(TargetingResult p0)
            {
                if (p0.TargetingResultStatus == TargetingResultStatus.Passed)
                {
                    Qualtrics.Instance().DisplayIntercept(Context, p0.InterceptID);
                }
            }
        }
    }
}