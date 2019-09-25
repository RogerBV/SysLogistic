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
                    //alert("Registro Exitoso");
                    $('#modalCategory').modal('hide');
                    this.List();
                });
        }
        , List: function (event) {
            axios.get("/Category/List",
                {
                    dataType: 'json'
                })
                .then(response => this.categories = response.data.data);
        }, AlertCategory: function (event) {
            console.log(event);
        }
        
    }, mounted() {
        this.List();
    }
});