var appWarehouse = new Vue({
    el: '#appWarehouse',
    data: {
          Id: 0
        , txtName: ''
        , txtDescription: ''
        , Warehouses: []
    },
    methods: {
        ClearForm: function (event) {
            this.Id = 0;
            this.txtName = "";
            this.txtDescription = "";
        },
        OpenWarehouse: function (event) {
            this.ClearForm();
            $("#modalWarehouse").modal("show");
        },
        FindWarehouse: function (event) {
            $("#modalWarehouse").modal('show');
            this.MappingEntityForm(event);
        },
        MappingEntityForm: function (event) {
            this.Id = event.Id;
            this.txtName = event.Name;
            this.txtDescription = event.Description;
        },
        UpdateWarehouse: function (event) {
            axios.post('/Warehouse/Update', { Id: this.Id, Name: this.txtName, Description: this.txtDescription })
                .then(response => {
                    $("#modalWarehouse").modal('hide');
                    this.List();
                });
        },
        SaveWarehouse: function (event) {
            axios.post('/Warehouse/create', { Name: this.txtName, Description: this.txtDescription })
                .then(response => {
                    $('#modalWarehouse').modal('hide');
                    this.List();
                });
        },
        Save: function (event) {
            if (this.Id == 0) {
                this.SaveWarehouse();
            }
            else {
                this.UpdateWarehouse();
            }
        },
        List: function (event) {
            axios.get("/Warehouse/List", {
                dataType: 'json'
            })
                .then(response => this.Warehouses = response.data.data);
        }
    },
    mounted() {
        this.List();
    }

});