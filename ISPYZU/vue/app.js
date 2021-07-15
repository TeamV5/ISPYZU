/*
const app = Vue.createApp({
    data() {
      return {
        firstName: 'John',
        lastName: 'Doe',
        email: 'john@gmail.com',
        gender: 'male',
        picture: 'https://randomuser.me/api/portraits/men/10.jpg',
      }
    },
    methods: {
       async getUser() {
           const res =await fetch('https://randomuser.me/api')
           const {results} =await res.json()

           console.log(results)
        
  
        this.firstName = results[0].name.first,
        this.lastName = results[0].name.last,
        this.email = results[0].email,
        this.gender = results[0].gender,
        this.picture = results[0].picture.medium  // VERY VERY VERY IMPORTANT I CAN NOT PUT COMMA HERE
      },
    },
  })
  
  app.mount('#app')

*/
  
const app= Vue.createApp({
   // template:'<h1>hello {{firstName}}</h1>',
    data(){
        return{
        firstName: 'Zahid',
        lastName: 'Pranta',
        email: 'pranta@gmail.com',
        gender: 'female',
            picture: 'http://localhost:63220/Vue/picture/zahid.jpg',
        }
    },
    methods:{
        getUser() {
          
            this.firstName= 'MD ',
            this.lastName = 'Shorifuzzaman ',
            this.email= 'rajputro@gmail.com',
            this.gender= 'female',
           // this.picture= 'https://randomuser.me/api/portraits/women/10.jpg', // for this comma there will be an error
      
                this.picture = 'http://localhost:63220/Vue/picture/shorif.jpg'
              
        },
        getUser1() {

            this.firstName = 'Musaberul ',
                this.lastName = 'siam ',
                this.email = 'Siam@gmail.com',
                this.gender = 'male',
                // this.picture= 'https://randomuser.me/api/portraits/women/10.jpg', // for this comma there will be an error

                this.picture = 'http://localhost:63220/Vue/picture/siam.jpg'

        },
        getUser2() {

            this.firstName = 'Al ',
                this.lastName = 'RAYHAN ',
                this.email = 'RAYHAN@gmail.com',
                this.gender = 'male',
                // this.picture= 'https://randomuser.me/api/portraits/women/10.jpg', // for this comma there will be an error

                this.picture = 'http://localhost:63220/Vue/picture/rayhan.jpg'

        },
        getUser3() {

            this.firstName = 'MD ',
                this.lastName = 'Noman ',
                this.email = 'noman@gmail.com',
                this.gender = 'male',
                // this.picture= 'https://randomuser.me/api/portraits/women/10.jpg', // for this comma there will be an error

                this.picture = 'http://localhost:63220/Vue/picture/noman.jpg'

        }

    }, //C: \Users\zahid\Desktop\clean\YZUASPPROJECT\newYZU\Vue_added\ISPYZU\vue\picture
})
app.mount('#app')

















/*const app = Vue.createApp({
    data() {
      return {
        firstName: 'John',
        lastName: 'Doe',
        email: 'john@gmail.com',
        gender: 'male',
        picture: 'https://randomuser.me/api/portraits/men/10.jpg',
      }
    },
    methods: {
      async getUser() {
        const res = await fetch('https://randomuser.me/api')
        const { results } = await res.json()
  
        // console.log(results)
  
        this.firstName = results[0].name.first
        this.lastName = results[0].name.last
        this.email = results[0].email
        this.gender = results[0].gender
        this.picture = results[0].picture.large
      },
    },
  })
  
  app.mount('#app')
  */