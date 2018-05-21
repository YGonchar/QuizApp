using System;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;

namespace QuizApp.Droid.Views
{
    public class QuestionHolder : RecyclerView.ViewHolder
    {
        private readonly View itemView;

        public QuestionHolder(View itemView) : base(itemView)
        {
            this.itemView = itemView;
        }

        protected QuestionHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        { }
    }
}