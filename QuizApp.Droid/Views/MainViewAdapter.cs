using Android.Support.V7.Widget;
using Android.Views;
using System.Collections.Generic;
using System.Linq;

public class MainViewAdapter : RecyclerView.Adapter
{
    private readonly IEnumerable<object> source;

    public MainViewAdapter(IEnumerable<object> source)
    {
        this.source = source;
    }
    public override int ItemCount => source.Count();

    public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
    {
        throw new System.NotImplementedException();
    }

    public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
    {
        
    }
}