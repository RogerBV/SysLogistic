var appProduct = new Vue({
    el: '#appProduct',
    data: {
        Id: 0,
        txtName: '',
        txtDescription: '',
        txtPrice: 0.00,
        cboCategory: '',
        categories: [],
        products: []
    }, methods: {
            ClearForm: function (event) {
                this.Id = 0;
                this.txtName = "";
                this.txtDescription = "";
                this.cboCategory = "";
            },
            OpenProduct: function (event) {
                this.ClearForm();
                $("#modalProduct").modal("show");
            },
            List: function (event) {
                axios.get('/Product/List', {
                    dataType: 'json'
                }).then(response => this.products = response.data.data);

            },
            ListCategories: function (event) {
                axios.get('/Product/ListCategories', {
                    dataType: 'json'
                }).then(response => this.categories = response.data.data);
            },
            SaveProduct: function (event) {
                axios.post("/Product/create", { Description: this.txtDescription, Name: this.txtName, Price: this.txtPrice, CategoryId: this.cboCategory })
                .then(response => {
                            $('#modalProduct').modal('hide');
                            this.List();
                            this.ClearForm();
                        });
            },
            UpdateProduct: function (event) {
                axios.post("/Product/Update", { Id: this.Id, Name: this.Name, Description: this.txtDescription, Price: this.txtPrice, CategoryId: this.cboCategory })
                    .then(response => {
                        $("#modalProduct").modal('hide');
                        this.List();
                        this.ClearForm();
                    });
            },
            FindProduct: function (event) {
                $("#modalProduct").modal('show');
                this.MappingEntityForm(event);
            },
            MappingEntityForm: function (event) {
                this.Id = event.Id;
                this.txtName = event.Name;
                this.txtDescription = event.Description;
                this.txtPrice = event.Price;
                this.cboCategory = event.CategoryId;
            },
            Save: function (event) {
                if (this.Id == 0) {
                    this.SaveProduct();
                } else {
                    this.UpdateProduct();
                }
            }


    }, mounted() {
        this.List();
        this.ListCategories();
    }
});