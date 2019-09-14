const category = {
    Name: ''
    ,Description: ''
}

const eCategory = Object.create(category);

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
                    //this.info = response.data.bpi
                });
        }
        , List: function (event) {
            axios.get("/Category/List")
                .then(function(response) {
                    //const lista = JSON.stringify(response.data);
                    console.log(response);
                    

                    this.categories = JSON.stringify(response.data);
                });
        }
        
    }, mounted() {
        this.List();
    }
});