var app = new Vue({
    el: '#app',
    data: {
        txtName: '',
        txtDescription: ''
        ,categories: []
    }, methods: {
        SaveCategory: function (event) {
            axios.post("/Category/create", { Description: this.txtDescription, Name: this.txtName })
                .then(response => {
                    alert("Registro Exitoso");
                    $('#modalCategory').modal('toggle');
                    this.List();
                });
        }
        , List: function (event) {
            axios.get("/Category/List",
                {
                    dataType: 'json'
                })
                .then(response => this.categories = response.data.data);
        }
        
    }, mounted() {
        this.List();
    }
});