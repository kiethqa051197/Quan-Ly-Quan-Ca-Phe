package com.example.coffemangement.Adapter;

import android.content.Context;
import android.content.Intent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.coffemangement.Model.Table;
import com.example.coffemangement.R;
import com.example.coffemangement.View.OrderActivity;

import java.util.List;

class ListTableViewHolder extends RecyclerView.ViewHolder{
    TextView txtNameTable;
    ImageView imgTable;
    LinearLayout itemtable;

    ListTableViewHolder(@NonNull View itemView) {
        super(itemView);

        txtNameTable = itemView.findViewById(R.id.txtNameTable);
        imgTable = itemView.findViewById(R.id.imgTable);
        itemtable = itemView.findViewById(R.id.itemtable);
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

        holder.itemtable.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent i = new Intent(context, OrderActivity.class);
                context.startActivity(i);
            }
        });
    }

    @Override
    public int getItemCount() {
        return tableList.size();
    }
}