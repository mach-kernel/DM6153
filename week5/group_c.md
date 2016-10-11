# Design Documents

## Game 1: "I gotta poop"

"Run home and avoid obstacles on your way to sweet relief, get home too late and poop your pants."

### Core Mechanic
- Running
- Jumping
- Racing against clock

### Stuff
- Modifiers/powerups that make you poop more or less
- Temptations: seeing advertisements for Miralax, or it starts raining and you now also really have to pee.
- Time wasters (coworkers, the police, your significant other, anything getting in the way of you and a toilet)
- High fidelity audio samples of farting. 

### Long form description
You always make poor decisions, springing for that extra spicy buffalo chicken sub at lunch every day. Refusing to change your ways, you must face the fact that every bathroom break is an emergency. You begin in your office, as you navigate around your coworkers avoiding small talk to run to the elevator and eventually your car. You cut through traffic as you drive to clear the stage on time, but have to walk a fine line of driving aggressively but not so much so that you would poop yourself. As you park, you run down the final sidewalk stretch avoiding any neighbors or obstacles, jumping over fences to get into your house, avoid everyone, and make it to the bathroom on time.

### Novelty
Poop sells.

### Questions hoping to answer

- What makes sense as a temptation/time waster/modifier?
- Do I provide enough entertainment past a 'time trial' game with functional sugar?
- Do people seem to be having fun past all the poop jokes/references?
- Can I make the player feel the agony of having to rush to the restroom (e.g am I immersive enough)?

### Things not tested
- Platforming motion (acceleration curves for running/jumping are easy to tweak and cosmetic)

## Game 2: Meme or No Meme

"Scroll through AI generated and human OC memes from aggregators and mark an image as meme or no meme"

### Core Mechanic
- User subjectivity
- Tinder style swipe for yes/no
- ML accuracy

### Stuff
- Meme aggregator sources (e.g 4chan, reddit, popular FB shitpost groups)
- Google DeepDream, Caffe ML library
- Memes themselves

### Long form description
This is a very open ended game that basically attempts to answer the question of 'what is a meme' by relying on the user for classification for memes that are both made by humans and computers. You could have an SVM attempt to classify both and use that to train DeepMind to create a meme that can pass the 'human test'. All this aside, users could get metrics from the ML libraries to see (for novelty) factor how good the machine is getting at making memes, and incentivize scoring memes through allowing the user to give more detailed training data (e.g, move from meme or no meme to, if no meme is selected, provide a meme that you think is similar to the one generated)

### Novelty
Machine learning is a pretty good buzzword and people love memes.

### Questions hoping to answer
- Is this actually a game or just a cool ML project?
- What makes memes fun?
- Does the machine learning aspect make the game interesting, e.g., would you like to train a meme-bot to see if it goes wild and does crazy shit?

### Things not tested
- Any actual ML accuracy, the point is for the algorithm to walk the line of passable vs. weird sci-fi vaporware
- UX cosmetics, must know if mechanic is tenable

## Game 3: Silicon Valley Simulator 2017

### Core Mechanic
- Build startups
- Create engineers
- Disrupt with buzzwords
- Make lots of $$$$$ with VC congolomerates
- Destroy families with acquisitions and liquidations

### Stuff 
- Sprites for buildings, software engineers, VCs, PCs, etc.
- Startup logo generator
- Buzzword generator
- Some NPC that goes "wow that's so webscale"

### Long form description
Imagine a meld of the sims and civ where you have to define Silicon Valley by disrupting the industry with a predefined 'next hottest thing' that changes every 30 minutes. Pivot your company, befriend VC, and do your best to stay relevant and avoid getting your company a downround or losing all your money and dying from stress. Recruit the best engineers, give them nice office amenities and make sure they are healthy enough to drive your MVP. Basically, make a game out of my life. 

### Novelty
`[next hottest thing].js`

### Questions hoping to answer
- Can I make the game engaging with a "growing startup theme"?
- Will any audience feel comfortable jumping in and playing, or only those familiar with the intimacies of SV and the VC/startup ecosystem?
- Is this just a skin on an existing game?

### Things not tested
- Controls/aesthetics
- I don't know what not to test here?

