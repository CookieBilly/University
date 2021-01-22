const Discord = require('discord.js');
const client = require('../../cookie');
const { get } = require('../../config');
let Trello = require('trello');
const { sleep } = require('./utility');
const { fetchFromHypixel, getHypixelDisplay } = require('./api');
const { bot } = require('./minecraft');
const fetch = require('node-fetch');
const r = require('rethinkdbdash')()
let trello = new Trello('47e943983576836bfdc4169f6ffe48c1', '5ac1bf5c5e590df8b34313dbc5f90c3296127d16091f04d085d4ec2fd48f1cf4');

const waitlist = {};



waitlist.plswork = async function(state, minecraftusername, subtype) {
    

    let currentlist = await waitlist.GetList()

    for(const person in currentlist) {
        if(currentlist[person].name.toLowerCase() == minecraftusername.toLowerCase()) {


            // check if they have the label already
            for(const label in currentlist[person].labels) {


                // invited
                if(currentlist[person].labels[label].id == '5fa3be4ccdabcf46c0a74eb2') {
                    if(`${state}` == 'invited') {return} else {
                       
                        trello.deleteLabelFromCard(currentlist[person].id, currentlist[person].labels[label].id)

                        if(`${state}` == 'invited') {
                            trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb2')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                            
                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("GREEN");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite sent:", `\`\`\`${subtype} invite to ${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                            discorduser.send(embed)
                        } else if(`${state}` == 'failed') {
                            trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb5')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("RED");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite failed:", `\`\`\`${currentlist[person].name} due to ${subtype}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                            discorduser.send(embed)
                        } else if(`${state}` == 'expired') {
                            trello.addLabelToCard(currentlist[person].id, '5fc51096eb58191cc277acda')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                                                        const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("ORANGE");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite expired:", `\`\`\`${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                            discorduser.send(embed)
                        }
                        
                        return;

                    }                    
                }

                // failed
                if(currentlist[person].labels[label].id == '5fa3be4ccdabcf46c0a74eb5') {

                    
                    if(`${state}` == 'failed') {return} else {

                        trello.deleteLabelFromCard(currentlist[person].id, currentlist[person].labels[label].id)

                        if(`${state}` == 'invited') {
                            trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb2')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                            discorduser.send(embed)

                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("GREEN");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite sent:", `\`\`\`${subtype} invite to ${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                            
                        } else if(`${state}` == 'failed') {
                            trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb5')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                            discorduser.send(embed)

                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("RED");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite failed:", `\`\`\`${currentlist[person].name} due to ${subtype}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);

                            
                        } else if(`${state}` == 'expired') {
                            trello.addLabelToCard(currentlist[person].id, '5fc51096eb58191cc277acda')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                            discorduser.send(embed)

                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("ORANGE");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite expired:", `\`\`\`${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                        }
                        
                        return;

                    }                    
                }


                // expired
                if(currentlist[person].labels[label].id == '5fc51096eb58191cc277acda') {
                    if(`${state}` == 'expired') {return} else {

                        trello.deleteLabelFromCard(currentlist[person].id, currentlist[person].labels[label].id)

                        if(`${state}` == 'invited') {
                            trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb2')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                                                        const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("GREEN");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite sent:", `\`\`\`${subtype} invite to ${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                            discorduser.send(embed)
                        } else if(`${state}` == 'failed') {
                            trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb5')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)

                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("RED");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite failed:", `\`\`\`${currentlist[person].name} due to ${subtype}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);

                            discorduser.send(embed)
                        } else if(`${state}` == 'expired') {
                            trello.addLabelToCard(currentlist[person].id, '5fc51096eb58191cc277acda')
                            let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                            let embed = await waitEmbed(state, subtype, currentlist[person].id)
                            
                            discorduser.send(embed)
                        }
                        
                        return;
                    }                    
                }

            }

            console.log(state)
            // if not: give label, message and comment
            if(`${state}` == 'invited') {

                console.log("bobobobobo")
                trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb2')
                let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                let embed = await waitEmbed(state, subtype, currentlist[person].id)
                                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("GREEN");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite sent:", `\`\`\`${subtype} invite to ${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                discorduser.send(embed)
                return;            

            }

            if(`${state}` == 'failed') {

                console.log("bobobobobo")
                trello.addLabelToCard(currentlist[person].id, '5fa3be4ccdabcf46c0a74eb5')
                let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                let embed = await waitEmbed(state, subtype, currentlist[person].id)
                const Embed1 = new Discord.MessageEmbed();
                Embed1.setColor("RED");
                Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                
                // Looping through the role and checking which role was added.
                Embed1.addField("Invite failed:", `\`\`\`${currentlist[person].name} due to ${subtype}\`\`\``);
                client.channels.cache.get("783322235195752479").send(Embed1);
                discorduser.send(embed)
                return;              


            }

            if(`${state}` == 'expired') {

                console.log("bobobobobo")
                trello.addLabelToCard(currentlist[person].id, '5fc51096eb58191cc277acda')
                let discorduser = await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase())
                let embed = await waitEmbed(state, null)
                                            const Embed1 = new Discord.MessageEmbed();
                            Embed1.setColor("ORANGE");
                            Embed1.setAuthor(client.user.tag, client.user.avatarURL());
                            
                            // Looping through the role and checking which role was added.
                            Embed1.addField("Invite expired:", `\`\`\`${currentlist[person].name}\`\`\``);
                            client.channels.cache.get("783322235195752479").send(Embed1);
                discorduser.send(embed)
                return;         

            }

        }
    }
    return;

}


async function waitEmbed(type, subtype, cardid) {
    

    if(type == 'invited') {

        const messageembed = new Discord.MessageEmbed()
        messageembed.setColor('#00FF00')

        // invited (online)
        if(subtype == 'online') {
            
            messageembed.setAuthor('You were invited to the guild!', 'https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flat_tick_icon.svg/1200px-Flat_tick_icon.svg.png')
            messageembed.setTitle('You were sent an invite, please accept it!')
            messageembed.setDescription('You were invited to The Cookie Factory on Hypixel! You were online when this invite was sent, as a result: this invite will automatically expire after `5 minutes`.\n\nIn order to accept the invite, please run the command:')
            trello.addCommentToCard(cardid, 'Automatically sent an online invite to the guild')
            

        }

        // invited (offline)
        if(subtype == 'offline') {

            messageembed.setAuthor('You were invited to the guild!', 'https://upload.wikimedia.org/wikipedia/commons/thumb/7/73/Flat_tick_icon.svg/1200px-Flat_tick_icon.svg.png')
            messageembed.setTitle('You were sent an invite, please accept it!')
            messageembed.setDescription('You were invited to The Cookie Factory on Hypixel! You were offline when this invite was sent, this means that the invite will stay until you next login, on your next login: you will have **5 minutes** to accept the invite before it expires.\n\nIn order to accept the invite, please run the command')
            trello.addCommentToCard(cardid, 'Automatically sent an offline invite to the guild')

        }

        messageembed.setImage('https://i.imgur.com/FSjcgzo.png')
        messageembed.setFooter('If you need help, feel free to send a message to an officer!', 'https://img.icons8.com/bubbles/2x/question-mark.png');
        

        return messageembed;

    }


    if(type == 'failed') {

        const messageembed = new Discord.MessageEmbed()
        messageembed.setColor('#FFA500')

        // failed (privacy)
        if(subtype == 'privacy') {
            
            messageembed.setAuthor('Unable to invite you to the guild!', 'https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flat_cross_icon.svg/1024px-Flat_cross_icon.svg.png')
            messageembed.setTitle('You have too strict privacy!')
            messageembed.setDescription('We tried to invite you to the guild, however: your current privacy settings prevented us from being able to invite you. Please change the settings by using the **/privacy** command on Hypixel, then clicking "Guild" and setting the privacy to "None".')
            trello.addCommentToCard(cardid, 'Invite failed due to privacy settings')

        }

        // failed (inaguild)
        if(subtype == 'inaguild') {

            messageembed.setAuthor('Unable to invite you to the guild!', 'https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flat_cross_icon.svg/1024px-Flat_cross_icon.svg.png')
            messageembed.setTitle('You are already in another guild!')
            messageembed.setDescription('We tried to invite you to the guild, however: you are currently in another guild. Please leave your current guild in order to be invited, if you\'d like to stay in your current guild - please message an officer so we can remove you from our waiting list!')
            trello.addCommentToCard(cardid, 'Invite failed due to in a guild already')

        }

        messageembed.setFooter('If you need help, feel free to send a message to an officer!', 'https://img.icons8.com/bubbles/2x/question-mark.png');
        return messageembed;

    }

    if(type == 'expired') {

        const messageembed = new Discord.MessageEmbed()
        messageembed.setColor('#FFA500')
           
        messageembed.setAuthor('Your invite has expired!', 'https://upload.wikimedia.org/wikipedia/commons/thumb/8/8f/Flat_cross_icon.svg/1024px-Flat_cross_icon.svg.png')
        messageembed.setTitle('Your invite to the guild has expired!')
        messageembed.setDescription('We tried to invite you to the guild, however: the invite automatically expired, this means that we\'ll have to invite you again! You will be automatically invited in **60 minutes**. Please note that we can only hold your position on the waiting list for up to 5 days!')
        trello.addCommentToCard(cardid, 'Invite to guild has expired')

        

        messageembed.setFooter('If you need help, feel free to send a message to an officer!', 'https://img.icons8.com/bubbles/2x/question-mark.png');
        return messageembed;

    }


}

async function getUsers(message, args, client) {
    try {
        let hypixel,
            user
        if (!isNaN(parseInt(args))) {
            user = client.guilds.cache.get(get('tcfServ')).members.cache.get(args)
            if (user) {
                let db = await db.getUser(user.id, null)
                hypixel = await fetchFromHypixel('player', 'uuid', db.uuid)
            } else user = null ; hypixel = null
        } else if (args.match('^[A-Za-z0-9_]+$')) {
            hypixel = await fetchFromHypixel('player', args.length <= 16 ? 'name' : 'uuid', args)
            let db = await db.getUser(user.id, null)
            let getUser = await db.getUser(null, hypixel.player.uuid)
            if (getUser) user = client.guilds.cache.get(get('tcfServ')).members.cache.get(getUser.discordID)
            else user = null
        }
        if (hypixel) return {discord: user, uuid: hypixel.player.uuid, hypixel: hypixel}
        else return null
    } catch(e) {return null}
}

// automated loops through invites, updateposition every 30 minutes
async function loopthrough() {
    waitlist.InviteNext()

    let waitinglist = await waitlist.GetList()

    // waiting list card 5fa430055b11c757e6599e39
    // field id 5fa430b0dbf67915201c144e  & id 5fa430b0dbf67915201c144e

    let url = `https://api.trello.com/1/card/5fa430055b11c757e6599e39/customField/5fa430b0dbf67915201c144e/item`
    let someData = {           
            idValue: '5fa430b0dbf67915201c144e',
            key: '47e943983576836bfdc4169f6ffe48c1',
            token: '5ac1bf5c5e590df8b34313dbc5f90c3296127d16091f04d085d4ec2fd48f1cf4',
            value: {
                text: `${waitinglist.length}`
            }
        }

    

    const putMethod = {
        method: 'PUT', 
        headers: {
        'Content-type': 'application/json' 
        },
        body: JSON.stringify(someData) // We send data in JSON format
    }
    
    // make the HTTP put request using fetch api
    fetch(url, putMethod)

    let waitlistmembers = await client.guilds.cache.get('569250659858120705').roles.cache.get('683157250902065153').members.map(m => m);

        // get last message id
        

        // if it's more than 4 days ago
        // check if user has inactive label

        // add inactive label

    let currentdate = await ((await Date.now()) / 1000) - 345600
    
    for(member in waitlistmembers) {

        let messagelist = await r.db('testing').table('messages').filter({author: `${waitlistmembers[member].user.id}`}).limit(100000)
        let inactive = true;

        for(messageu in messagelist) {

            if(Math.floor(messagelist[messageu].date / 1000) > currentdate) {
                inactive = false
            }

        }

        if(inactive == true) {
            let waitinglist = await waitlist.GetList()
            for(card in waitinglist) {

                if(waitinglist[card].name == waitlistmembers[member].displayName) {
                    let labely = false;

                    for(const label in waitinglist[card].labels) {
                        if(waitinglist[card].labels[label].id == '5fd2a5e97034586b12980738') {
                            labely = true;
                        }
                    }

                    if(labely == false) {
                        trello.addCommentToCard(waitinglist[card].id, 'Inactive for **3+** days, added inactive label.')
                        trello.addLabelToCard(waitinglist[card].id, '5fd2a5e97034586b12980738')
                        client.channels.cache.get('797160499057131540').send(`<@&690367874702770206> ${waitlistmembers[member].displayName} inactive whilst on waitlist (3+ days). Please private message.`)
                    }
                }


            }
        }
    }




}

setInterval(async() => await loopthrough(), 600000)

//setInterval(async() => await loopthrough(), 1800000)

waitlist.UpdatePositions = async function() {

    let waitinglist = await waitlist.GetList()
    let currentloop = 0

    for (const person in waitinglist) {

        await sleep(3000).then(function() {
        
            // current position
            currentloop = currentloop + 1


            // push change of position
            // https://api.trello.com/1/customField/5a6a23abf958725e1ac86c21/options/5a6a2799f958725e1ac86c7a

            let url = `https://api.trello.com/1/card/${waitinglist[person].id}/customField/5fa42e4be5b1061c9ffd6a88/item`
            let someData = {           
                    idValue: '5fc51d3e31c40945938a48d3',
                    key: '47e943983576836bfdc4169f6ffe48c1',
                    token: '5ac1bf5c5e590df8b34313dbc5f90c3296127d16091f04d085d4ec2fd48f1cf4',
                    value: {
                        text: `${currentloop}`
                    }
                }

            

            const putMethod = {
                method: 'PUT', 
                headers: {
                'Content-type': 'application/json' 
                },
                body: JSON.stringify(someData) // We send data in JSON format
            }
            
            // make the HTTP put request using fetch api
            fetch(url, putMethod)

        }

        )}
}

/**
 * @param {String} minecraftusername Minecraft username/uuid to move
 * @param {String} type Where to move it to (e.g. cancelled, joined, list, hover)
 **/
waitlist.Move = async function(type, minecraftusername, uuid) {

    async function clearcard(cardid) {

        // move to board
        let waitinglist = await waitlist.GetList()

        let url = `https://api.trello.com/1/card/${cardid}/customField/5fa42e4be5b1061c9ffd6a88/item`
        let someData = {           
                idValue: '',
                key: '47e943983576836bfdc4169f6ffe48c1',
                token: '5ac1bf5c5e590df8b34313dbc5f90c3296127d16091f04d085d4ec2fd48f1cf4',
                value: {
                    text: ' '
                }
            }

        

        const putMethod = {
            method: 'PUT', 
            headers: {
            'Content-type': 'application/json' 
            },
            body: JSON.stringify(someData) // We send data in JSON format
        }
        
        // make the HTTP put request using fetch api
        fetch(url, putMethod)

    }

    let waitinglist = await waitlist.GetAllCards()


    for(const person in waitinglist) {

        
        if(waitinglist[person].name.toLowerCase() == minecraftusername.toLowerCase()) {

            if(type == 'cancelled') {
                trello.updateCardList(waitinglist[person].id, '5fa3be78c5945d6eabf73130')
                clearcard(waitinglist[person].id)
            }

            if(type == 'joined') {
                trello.updateCardList(waitinglist[person].id, '5fa3be7290bc6a35620cd1a2')
                clearcard(waitinglist[person].id)
            }

            if(type == 'list' || type == 'discord') {

                if(waitinglist[person].idList == '5fc4ee759710bf0b7085364c' || waitinglist[person].idList == '5fa3c452103e206c14ba255d') {

                    trello.deleteCard(waitinglist[person].id)
                    waitlist.addToList('discord', minecraftusername, uuid)
                    return true;

                }

            }

            if(type == 'notindiscord') {
                trello.updateCardList(waitinglist[person].id, '5fa3c452103e206c14ba255d')
                clearcard(waitinglist[person].id)
            }

            if(type == 'hover') {
                trello.updateCardList(waitinglist[person].id, '5fc4ee759710bf0b7085364c')
                clearcard(waitinglist[person].id)
            }

        }
        

    }
    
}

/**
 * @param {String} minecraftusername Minecraft username/uuid to add to list
 * @param {String} type List area (e.g. discord/notdiscord/hover)
 **/
waitlist.addToList = async function(type, minecraftusername, uuid) {
      
    if(type == 'notdiscord') {
        trello.addCard(minecraftusername, uuid, '5fa3c452103e206c14ba255d', 
        function (error, trelloCard) {
            trello.addCommentToCard(trelloCard.id, 'Added to waiting list (not in discord)')
        })
    } else if(type == 'discord') {
        trello.addCard(minecraftusername, uuid, '5fa3be5fb794bf533bae67e8', 
        function (error, trelloCard) {
            trello.addCommentToCard(trelloCard.id, 'Added to waiting list (in discord)')
        })

        await client.guilds.cache.get('569250659858120705').members.cache.find(u => u.displayName.toLowerCase() === minecraftusername.toLowerCase()).roles.add('683157250902065153')
    
    
    }
    
}


waitlist.GetAllCards = async function() {


    let cardsonboard = await trello.getCardsOnBoard('5fa3be4c3b83cf7780642a3c')
    return cardsonboard;
    
}


waitlist.GetList = async function() {


    let cardsonboard = await trello.getCardsOnBoard('5fa3be4c3b83cf7780642a3c')
    let waitinglist = []

    for(const card in cardsonboard)
    {



        let currentcard = cardsonboard[card]
        if(currentcard.idList == '5fa3be5fb794bf533bae67e8') {
            if(currentcard.id != '5fc96945d4e421621673f2d7') {            waitinglist.push(currentcard)
            }
        }
    } 

    return waitinglist;
    
}

waitlist.InviteNext = async function() {

    let waitinglist = await waitlist.GetList()
    let guild = await fetchFromHypixel('guild', 'id', '5ad3c65f0cf2a4518db44cf7')
    let amountofpeople = guild.guild.members.length
   
    if(amountofpeople < 125) {

        let slots = 125 - amountofpeople
        let loops = 0

        for (const person in waitinglist) {

            await sleep(3000).then(await async function() {

                loops = loops + 1


                if(loops <= slots) {

                    let alreadyinvited = false

                    for(const label in waitinglist[person].labels) {

                        // already invite
                        if(waitinglist[person].labels[label].id == '5fa3be4ccdabcf46c0a74eb2' ) {
                            alreadyinvited = true
                        }
                    

                    }

                    if(alreadyinvited == false) {

                        // TODO - check if member is in a guild before inviting
                        // waitlist.InviteState("failed", username, "inaguild")

                        client.lastinvited = waitinglist[person].name
                        console.log(`Inviting person #${loops} on waitlist`)
                        bot.chat(`/g invite ${waitinglist[person].desc}`)
                        
                    }

                }

            })}

    }



    waitlist.UpdatePositions()

}


waitlist.UpdateName = async function(oldname, newname) {
    
    let waitinglist = await waitlist.GetList()

    for (const person in waitinglist) {

        
        if(waitinglist[person].name.toLowerCase() == oldname.toLowerCase()) {
            trello.updateCard(waitinglist[person].id, 'name', newname)
            trello.addCommentToCard(waitinglist[person].id, `IGN changed from **${oldname}** to **${newname}**`)
        }

    }

}


module.exports = waitlist;

