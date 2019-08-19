<template>
  <section class="search">
      <h1>Track Player Stats</h1>
      <form v-on:submit.prevent="onSubmit">
          <div class="form-group">
              <label for="platafor">Plataform</label>
              <select name="plataform" id="plataform" v-model="plataform">
                  <option value="psn">Playstation</option>
                  <option value="xbl">XBox</option>
                  <option value="Origin">Origin</option>
              </select>
          </div>
          <div class="form-group">
              <label for="gamertag">Gamertag</label>
              <input type="text" name="" v-model="gamertag" placeholder="Origin ID, XBox Live gamertag, PSN ID, etc..." id="gamertag">
          </div>
          <div class="form-group">
              <input type="submit" value="Submit" class="btn">
          </div>
      </form>
  </section>
</template>

<script>
export default {
    name: 'Search',
    data(){
        return{
            plataform: "psn",
            gamertag: ""
        };
    },
    beforeCreate(){
        document.body.className = "body-bg-image";
    },
    methods:{
        onSubmit(){
            if(!this.gamertag){
                this.$toasted.show("Enter Gamertag",{
                    duration: 3000,
                    icon: "exclamation-circle"
                });
            }
            else{
                this.$router.push(`/profile/${this.plataform}/${this.gamertag}`);
            }
        }
    }
}
</script>

<style>

</style>