//
//  Copyright 2012  Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Views;
using Android.Widget;

namespace FieldService.Android {
    public class SpinnerAdapter : BaseAdapter, ISpinnerAdapter {
        List<string> items;
        Activity activity;
        public SpinnerAdapter (List<string> items, Activity activity)
            : base ()
        {
            this.items = items;
            this.activity = activity;
        }

        public override Java.Lang.Object GetItem (int position)
        {
            return items [position];
        }

        public override int Count
        {
            get { return items.Count; }
        }

        public override long GetItemId (int position)
        {
            return (long)position;
        }

        public override View GetView (int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            if (view == null) {
                LayoutInflater inflator = (LayoutInflater)activity.GetSystemService (Context.LayoutInflaterService);
                view = inflator.Inflate (Resource.Layout.SimpleSpinnerItem, null);
            }

            var item = items.ElementAtOrDefault (position);
            if (item == null) {
                return view;
            }

            var textView = view.FindViewById<TextView> (Resource.Id.simpleSpinnerTextView);
            textView.Text = item;
            textView.SetBackgroundColor (Color.White);

            return view;
        }
    }
}