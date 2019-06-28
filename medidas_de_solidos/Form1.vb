Public Class Form1

    'density of aluminium
    Dim pt As Double = 2.7

    'for rectangular plaque measurement
    Private Sub calc_btn1_Click(sender As Object, e As EventArgs) Handles calc_btn1.Click

        pt = 2.7

        If longitude_txt.Text <> "" And height_txt1.Text <> "" And width_txt.Text <> "" And mass_txt1.Text <> "" Then

            vp_result_lbl.Text = (Val(longitude_txt.Text) * Val(height_txt1.Text) * Val(width_txt.Text))
            vp_deriv_result_lbl.Text = Val(vp_result_lbl.Text) * Math.Sqrt(Math.Pow((0.01 / Val(longitude_txt.Text)), 2) + Math.Pow((0.001 / Val(height_txt1.Text)), 2) + Math.Pow((0.001 / Val(width_txt.Text)), 2))
            pp_result_lbl.Text = (Val(mass_txt1.Text) / Val(vp_result_lbl.Text))
            pp_deriv_result_lbl.Text = (Val(pp_result_lbl.Text) * Math.Sqrt((Math.Pow(0.1 / Val(mass_txt1.Text), 2) + (Math.Pow(Val(vp_deriv_result_lbl.Text) / Val(vp_result_lbl.Text), 2)))))
            err_result_lbl1.Text = Math.Abs((pt - Val(pp_result_lbl.Text)) / pt) * 100

        End If
    End Sub

    'for sphere measurement
    Private Sub calc_btn2_Click(sender As Object, e As EventArgs) Handles calc_btn2.Click

        pt = 8.1

        If diameter_txt1.Text <> "" And mass_txt2.Text <> "" Then

            ve_result_lbl.Text = (Math.PI / 6) * Math.Pow(Val(diameter_txt1.Text), 3)
            ve_deriv_result_lbl.Text = (Math.PI / 2) * Math.Pow(Val(diameter_txt1.Text), 2) * (0.001)
            pe_result_lbl.Text = (Val(mass_txt2.Text) / Val(ve_result_lbl.Text))
            pe_deriv_result_lbl.Text = Val(pe_result_lbl.Text) * Math.Sqrt(Math.Pow(0.1 / Val(mass_txt2.Text), 2) + Math.Pow(Val(ve_deriv_result_lbl.Text) / Val(ve_result_lbl.Text), 2))
            err_result_lbl2.Text = Math.Abs((pt - Val(pe_result_lbl.Text)) / pt) * 100

        End If
    End Sub

    'for cylinder measurement
    Private Sub cal_btn3_Click(sender As Object, e As EventArgs) Handles cal_btn3.Click

        pt = 8.1

        If diameter_txt2.Text <> "" And height_txt2.Text <> "" And mass_txt3.Text <> "" Then

            vc_result_lbl.Text = (Math.PI / 4) * Math.Pow(Val(diameter_txt2.Text), 2) * Val(height_txt2.Text)
            vc_deriv_result_lbl.Text = Val(vc_result_lbl.Text) * Math.Sqrt(Math.Pow(((2 * 0.001) / Val(diameter_txt2.Text)), 2) + Math.Pow((0.01 / Val(height_txt2.Text)), 2))
            pc_result_lbl.Text = (Val(mass_txt3.Text) / Val(vc_result_lbl.Text))
            pc_deriv_result_lbl.Text = Val(pc_result_lbl.Text) * Math.Sqrt(Math.Pow(0.1 / Val(mass_txt3.Text), 2) + Math.Pow(Val(vc_deriv_result_lbl.Text) / Val(vc_result_lbl.Text), 2))
            err_result_lbl3.Text = Math.Abs((pt - Val(pc_result_lbl.Text)) / pt) * 100

        End If
    End Sub
End Class
