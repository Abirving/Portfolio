import React from 'react'; // Add this line at the top
import { motion } from "framer-motion";
import { FaHtml5, FaPhp, FaReact, FaJs, FaServer } from "react-icons/fa";

// ... rest of your code remains the same ...

const skills = [
  { 
    name: "HTML5", 
    level: 95,
    icon: <FaHtml5 />,
    color: "#E34F26"
  },
  { 
    name: "PHP", 
    level: 85,
    icon: <FaPhp />,
    color: "#777BB4"
  },
  { 
    name: "React", 
    level: 70,
    icon: <FaReact />,
    color: "#61DAFB"
  },
  { 
    name: "MERN Stack", 
    level: 60,
    icon: <FaServer />,
    color: "#3FA037"
  },
  { 
    name: "JavaScript", 
    level: 88,
    icon: <FaJs />,
    color: "#F7DF1E"
  },
];

const Skills = () => {
  return (
    <motion.section
      initial={{ opacity: 0, y: 50 }}
      animate={{ opacity: 1, y: 0 }}
      transition={{ duration: 0.6 }}
      className="min-h-screen py-12 bg-gradient-to-b from-gray-100 to-white dark:from-gray-900 dark:to-gray-800"
    >
      <div className="max-w-5xl mx-auto px-4">
        <motion.h2
          initial={{ opacity: 0, y: -20 }}
          animate={{ opacity: 1, y: 0 }}
          transition={{ duration: 0.5 }}
          className="text-4xl font-bold text-center mb-12 text-transparent bg-clip-text bg-gradient-to-r from-blue-600 to-purple-600"
        >
          My Tech Stack
        </motion.h2>

        <motion.div 
          className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-6"
          variants={{
            hidden: { opacity: 0 },
            visible: {
              opacity: 1,
              transition: {
                staggerChildren: 0.2
              }
            }
          }}
          initial="hidden"
          animate="visible"
        >
          {skills.map((skill, index) => (
            <motion.div
              key={index}
              className="bg-white dark:bg-gray-800 p-6 rounded-2xl shadow-lg hover:shadow-xl transition-shadow"
              whileHover={{ scale: 1.05 }}
              transition={{ type: 'spring', stiffness: 300 }}
            >
              <div className="flex items-center space-x-4 mb-4">
                <div 
                  className="p-3 rounded-lg"
                  style={{ backgroundColor: `${skill.color}30` }}
                >
                  {React.cloneElement(skill.icon, { 
                    size: 36, 
                    color: skill.color 
                  })}
                </div>
                <h3 className="text-xl font-semibold dark:text-white">
                  {skill.name}
                </h3>
              </div>
              
              <div className="space-y-2">
                <div className="flex justify-between text-sm text-gray-600 dark:text-gray-400">
                  <span>Beginner</span>
                  <span>Expert</span>
                </div>
                <motion.div
                  className="h-2 rounded-full bg-gray-200 dark:bg-gray-700"
                  initial={{ width: 0 }}
                  animate={{ width: `${skill.level}%` }}
                  transition={{ 
                    type: "spring",
                    stiffness: 100,
                    damping: 15,
                    duration: 1.5
                  }}
                >
                  <div 
                    className="h-full rounded-full"
                    style={{ 
                      backgroundColor: skill.color,
                      boxShadow: `0 0 10px ${skill.color}50`
                    }}
                  />
                </motion.div>
              </div>
            </motion.div>
          ))}
        </motion.div>
      </div>
    </motion.section>
  );
};

export default Skills;