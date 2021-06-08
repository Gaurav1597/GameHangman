using Android.Content;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace GameHangman.Classes
{
    //CUSTOM ADAPTER FOR HIGH SCORES LIST
    class MyListViewAdapter : BaseAdapter<Player>
    {
        private List<Player> playerList;
        private Context mContext;

        public MyListViewAdapter(Context context, List<Player> items)
        {
            playerList = items;
            mContext = context;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.highScoreRow, null, false);
            }

            TextView txtName = row.FindViewById<TextView>(Resource.Id.hiScoreName);
            txtName.Text = playerList[position].Name;
            TextView txtScore = row.FindViewById<TextView>(Resource.Id.hiScoreValue);
            txtScore.Text = playerList[position].HighScore.ToString();
            return row;
        }

        public override int Count
        {
            get { return playerList.Count; }
        }

        public override Player this[int position]
        {
            get { return playerList[position]; }
        }
    }
}
