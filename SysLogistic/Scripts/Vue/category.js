var app = new Vue({
    el: '#app',
    data: {
        Id: 0,
        txtName: '',
        txtDescription: ''
        ,categories: []
    }, methods: {
        Save: function (event) {
            if (this.Id == 0) {
                this.SaveCategory(event);
            } else {
                this.UpdateCategory(event);
            }
        },
        OpenCategory: function (event) {
            this.ClearForm();
            $("#modalCategory").modal('show');
        },
        SaveCategory: function (event) {
            axios.post("/SysLogistic/Category/create", { Name: this.txtName, Description: this.txtDescription })
                .then(response => {
                    $('#modalCategory').modal('hide');
                    this.List();
                    this.ClearForm();
                });
        }
        , UpdateCategory: function (event) {
            axios.post("/Category/Update", { Name: this.txtName, Description: this.txtDescription, Id : this.Id })
                .then(response => {
                    $('#modalCategory').modal('hide');
                    this.List();
                    this.ClearForm();

                });
        }
        , List: function (event) {
            axios.get("/Syslogistic/Category/List",
                {
                    dataType: 'json'
                })
                .then(response => this.categories = response.data.data);
        }, FindCategory: function (event) {
            $('#modalCategory').modal('show');
            this.MappingEntityToForm(event);
        }, MappingEntityToForm: function (event) {
            this.Id = event.Id;
            this.txtName = event.Name;
            this.txtDescription = event.Description;
        }, ClearForm: function(event) {
            this.Id = 0;
            //$("#txtName").value = "";
            //$("#txtDescription").value = "";
            this.txtName = "";
            this.txtDescription = "";
        }
        
    }, mounted() {
        this.List();
    }
});