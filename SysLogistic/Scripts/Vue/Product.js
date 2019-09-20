var appProduct = new Vue({
    el: '#appProduct',
    data: {
        txtName: '',
        txtDescription: '',
        txtPrice: 0.00,
        cboCategory: '',
        categories: [],
        products: []
    }, methods: {
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
                            alert("Registro Exitoso");
                            $('#modalProduct').modal('toggle');
                            this.List();
                        });
                }
    }, mounted() {
        this.List();
        this.ListCategories();
    }
});