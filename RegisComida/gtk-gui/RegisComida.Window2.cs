
// This file has been generated by the GUI designer. Do not modify.
namespace RegisComida
{
	public partial class Window2
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Table table1;

		private global::Gtk.Button btnOff;

		private global::Gtk.Button btnOn;

		private global::Gtk.Entry entContra;

		private global::Gtk.Label label1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget RegisComida.Window2
			this.Name = "RegisComida.Window2";
			this.Title = global::Mono.Unix.Catalog.GetString("Control");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child RegisComida.Window2.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.table1 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.btnOff = new global::Gtk.Button();
			this.btnOff.CanFocus = true;
			this.btnOff.Name = "btnOff";
			this.btnOff.UseUnderline = true;
			this.btnOff.Label = global::Mono.Unix.Catalog.GetString("Apagar");
			this.table1.Add(this.btnOff);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1[this.btnOff]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnOn = new global::Gtk.Button();
			this.btnOn.CanFocus = true;
			this.btnOn.Name = "btnOn";
			this.btnOn.UseUnderline = true;
			this.btnOn.Label = global::Mono.Unix.Catalog.GetString("Encender");
			this.table1.Add(this.btnOn);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.btnOn]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entContra = new global::Gtk.Entry();
			this.entContra.CanFocus = true;
			this.entContra.Name = "entContra";
			this.entContra.IsEditable = true;
			this.entContra.InvisibleChar = '•';
			this.table1.Add(this.entContra);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.entContra]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Contraseña");
			this.table1.Add(this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			this.fixed1.Add(this.table1);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.table1]));
			w5.X = 51;
			w5.Y = 36;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 138;
			this.Show();
			this.btnOn.Clicked += new global::System.EventHandler(this.On_clicked);
			this.btnOff.Clicked += new global::System.EventHandler(this.Off_clicked);
		}
	}
}
