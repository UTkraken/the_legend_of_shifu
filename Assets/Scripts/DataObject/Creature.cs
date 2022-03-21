using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataObject
{

    public class Creature : MonoBehaviour
    {

        // entity var
        private int health;
        private int maxHealth;
        private Vector3 position;
        private bool invincible;

        //entity fnc
        public void LoseHealth(int damageValue)
        {
            if (!this.invincible)
            {
                this.health -= damageValue;
                if (this.health < 0)
                {
                    this.health = 0;
                }

            }
        }

        public int GetHealth()
        {
            return this.health;
        }

        public void Heal(int healValue)
        {
            this.health += healValue;
            if (this.health > this.maxHealth)
            {
                this.health = this.maxHealth;
            }
        }

        public void FullHeal()
        {
            this.Heal(maxHealth);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

