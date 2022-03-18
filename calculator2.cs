private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text); // casting
            var b = Convert.ToInt32(txtNilaiB.Text); // casting

           // ubah txthasil dengan nilai perhitungan
		   
		   if (cmb1.SelectedIndex == 0)
		   {
			txtHasil.Text = Convert.ToString(Penambahan(a, b));
		   }
			
			if (cmb1.SelectedIndex == 1)
		   {
			txtHasil.Text = Convert.ToString(Pengurangan(a, b));
		   }
		   
		   if (cmb1.SelectedIndex == 2)
		   {
			txtHasil.Text = Convert.ToString(Perkalian(a, b));
		   }
		   
		   if (cmb1.SelectedIndex == 3)
		   {
			txtHasil.Text = Convert.ToString(Pembagian(a, b));
		   }
		}
    }
}

if ( nilai


{
	var a = int.Parse((txtNilaiA.Text); // casting
	var b = Convert.ToInt32(txtNilaiB.Text); // casting
	
	lstHasil.Items.Clear(); // kosongkan isi listbox
	
	// tampilkan hasil semua hasil pemanggilan method calculator ke dalam listbox
	lstHasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b)));
	lstHasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b)));
	lstHasil.Items.Add(string.Format("Hasil Perkalian: {0} * {1} = {2}", a, b, Perkalian(a, b)));
	lstHasil.Items.Add(string.Format("Hasil Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b)));
}
	
	
	
	
	
	