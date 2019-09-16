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
            axios.get("/Category/List",
                {
                    dataType: 'json'
                })
                /*.then(function (response) {
                    
                    console.log(JSON.stringify(response.data.data));
                    
                    this.categories = JSON.stringify(response.data.data);
                });*/
                .then(response => this.categories = response.data.data);
        }
        
    }, mounted() {
        this.List();
    }
});