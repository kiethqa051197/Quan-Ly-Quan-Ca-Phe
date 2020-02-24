package com.example.coffemangement.Adapter;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.coffemangement.Model.Table;
import com.example.coffemangement.R;
import com.example.coffemangement.View.OrderActivity;

import java.util.List;

class ListTableViewHolder extends RecyclerView.ViewHolder{
    TextView txtNameTable;
    ImageView imgOrder, imgPayment, imgHideButton, imgTable;
    RelativeLayout itemtable;

    ListTableViewHolder(@NonNull View itemView) {
        super(itemView);

        txtNameTable = itemView.findViewById(R.id.txtNameTable);
        imgTable = itemView.findViewById(R.id.imgTable);
        itemtable = itemView.findViewById(R.id.itemtable);

        imgOrder = itemView.findViewById(R.id.imgOrder);
        imgPayment = itemView.findViewById(R.id.imgPayment);
        imgHideButton = itemView.findViewById(R.id.imgHideButton);
    }
}

public class ListTableAdapter extends RecyclerView.Adapter<ListTableViewHolder>{
    private List<Table> tableList;
    private Context context;

    public ListTableAdapter(List<Table> tableList) {
        this.tableList = tableList;
    }

    @NonNull
    @Override
    public ListTableViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        context = parent.getContext();
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        View view = inflater.inflate(R.layout.item_table, parent, false);

        return new ListTableViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull final ListTableViewHolder holder, final int position) {
        final Table table = tableList.get(position);

        holder.txtNameTable.setText(table.getName());

        if (table.getStatus().equals("Trống")){
            holder.imgTable.setImageResource(R.drawable.table);
        }else {
            holder.imgTable.setImageResource(R.drawable.table_true);
        }

        holder.itemtable.setTag(table.getId());

        holder.imgTable.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ShowButton(holder);
            }
        });

        holder.imgHideButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                HideButton(true, holder);
            }
        });

        holder.imgOrder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent iOder = new Intent(context, OrderActivity.class);
                iOder.putExtra("table", holder.itemtable.getTag().toString());
                context.startActivity(iOder);
            }
        });
    }

    @Override
    public int getItemCount() {
        return tableList.size();
    }

    private void ShowButton(ListTableViewHolder holder){
        holder.imgOrder.setVisibility(View.VISIBLE);
        holder.imgPayment.setVisibility(View.VISIBLE);
        holder.imgHideButton.setVisibility(View.VISIBLE);

        Animation animation = AnimationUtils.loadAnimation(context, R.anim.hieuung_hienthi_button_banan);
        holder.imgOrder.startAnimation(animation);
        holder.imgPayment.startAnimation(animation);
        holder.imgHideButton.startAnimation(animation);
    }

    private void HideButton(boolean hieuung, ListTableViewHolder holder){
        if (hieuung){
            Animation animation = AnimationUtils.loadAnimation(context, R.anim.hieuung_anbutton_banan);
            holder.imgOrder.startAnimation(animation);
            holder.imgPayment.startAnimation(animation);
            holder.imgHideButton.startAnimation(animation);
        }

        holder.imgOrder.setVisibility(View.INVISIBLE);
        holder.imgPayment.setVisibility(View.INVISIBLE);
        holder.imgHideButton.setVisibility(View.INVISIBLE);
    }
}
