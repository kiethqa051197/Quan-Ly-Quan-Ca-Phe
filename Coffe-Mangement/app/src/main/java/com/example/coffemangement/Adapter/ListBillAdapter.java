package com.example.coffemangement.Adapter;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.coffemangement.Model.Menu;
import com.example.coffemangement.R;

import java.util.List;

class ListBillViewHolder extends RecyclerView.ViewHolder{
    TextView txtFoodName, txtPrice, txtTotalPrice, txtCountDown, txtCountUp;
    EditText edCountFood;
    LinearLayout itemOder;

    ListBillViewHolder(@NonNull View itemView) {
        super(itemView);

        txtFoodName = itemView.findViewById(R.id.txtFoodName);
        txtPrice = itemView.findViewById(R.id.txtPrice);
        txtTotalPrice = itemView.findViewById(R.id.txtTotalPrice);
        txtCountDown = itemView.findViewById(R.id.txtCountDown);
        txtCountUp = itemView.findViewById(R.id.txtCountUp);
        itemOder = itemView.findViewById(R.id.itemOder);

        edCountFood = itemView.findViewById(R.id.edCountFood);
    }
}

public class ListBillAdapter extends RecyclerView.Adapter<ListBillViewHolder>{
    private List<Menu> menuList;
    private Context context;

    public ListBillAdapter(List<Menu> menuList) {
        this.menuList = menuList;
    }

    @NonNull
    @Override
    public ListBillViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        context = parent.getContext();
        LayoutInflater inflater = LayoutInflater.from(parent.getContext());
        View view = inflater.inflate(R.layout.item_oder, parent, false);

        return new ListBillViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ListBillViewHolder holder, int position) {
        final Menu menu = menuList.get(position);

        holder.txtFoodName.setText(menu.getName());
        holder.txtPrice.setText((int) menu.getPrice());
        holder.edCountFood.setText(menu.getCount());
        holder.txtTotalPrice.setText((int) menu.getTotalPrice());
    }

    @Override
    public int getItemCount() {
        return menuList.size();
    }
}
